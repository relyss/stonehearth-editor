﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StonehearthEditor.Effects;
using Newtonsoft.Json.Linq;

namespace StonehearthEditor
{
    public partial class EffectsEditorView : UserControl, IReloadable
    {
        private Dictionary<string, FileData> mFileDataMap = new Dictionary<string, FileData>();
        private TreeNode mSelectedNode = null;
        private string mNewFilePath = null;
        private EffectsChromeBrowser mEffectsChromeBrowser;

        public EffectsEditorView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            // Initialize cef
            mEffectsChromeBrowser = EffectsChromeBrowser.GetInstance();
            mEffectsChromeBrowser.InitBrowser(this.effectsBrowserPanel);

            ModuleDataManager.GetInstance().PopulateTreeView(effectsEditorTreeView, "effects", "/data/effects");
            ModuleDataManager.GetInstance().PopulateTreeView(cubemittersTreeView, "cubemitters", "/data/horde/particles");
            ModuleDataManager.GetInstance().PopulateTreeView(lightsTreeView, "", "/data/horde/animatedlights");
            ModuleDataManager.GetInstance().PopulateTreeView(skySettingsTreeView, "sky_settings", "");
        }

        private IEnumerable<TreeNode> GetAllNodes(TreeView treeView)
        {
            Stack<TreeNode> toProcess = new Stack<TreeNode>();
            foreach (TreeNode node in treeView.Nodes)
            {
                toProcess.Push(node);
            }

            while (toProcess.Count > 0)
            {
                TreeNode node = toProcess.Pop();
                yield return node;
                foreach (TreeNode child in node.Nodes)
                {
                    toProcess.Push(child);
                }
            }
        }

        public void Reload()
        {
            filePreviewTabs.TabPages.Clear();
            effectsEditorTreeView.Nodes.Clear();
            cubemittersTreeView.Nodes.Clear();
            ModuleDataManager.GetInstance().PopulateTreeView(effectsEditorTreeView, "effects", "/data/effects");
            ModuleDataManager.GetInstance().PopulateTreeView(cubemittersTreeView, "cubemitters", "/data/horde/particles");
            ModuleDataManager.GetInstance().PopulateTreeView(lightsTreeView, "", "/data/horde/animatedlights");
            ModuleDataManager.GetInstance().PopulateTreeView(skySettingsTreeView, "sky_settings", "");

            TreeView treeView = GetTreeView(treeViewTabControl.SelectedIndex);

            // If we are making a new file, select it in the treeview
            if (mNewFilePath != null)
            {
                TreeNode[] matchingNodes = GetAllNodes(treeView)
                                                   .Where(r => r.Tag != null && r.Tag.ToString() == mNewFilePath)
                                                   .ToArray();
                if (matchingNodes.Length > 0)
                {
                    treeView.SelectedNode = matchingNodes.First();
                    mSelectedNode = treeView.SelectedNode;
                    mNewFilePath = null;
                }
            }
            else if (mSelectedNode != null)
            {
                treeView.SelectedNode = mSelectedNode;
            }
        }

        private void effectsOpenFileButton_Click(object sender, EventArgs e)
        {
            openEffectsFileDialog.InitialDirectory = MainForm.kModsDirectoryPath;
            openEffectsFileDialog.ShowDialog(this);
        }

        private void openEffectsFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openEffectsFileDialog.FileName;
            if (filePath == null)
            {
                return;
            }

            LoadFilePreview(filePath);
        }

        // Loads file preview from single FileData
        private void FillFilePreview(FileData fileData)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = fileData.FileName;

            // if (fileData.IsModified)
            // {
            //   newTabPage.Text = newTabPage.Text + "*";
            // }
            if (fileData.HasErrors)
            {
                newTabPage.ImageIndex = 0;
                newTabPage.ToolTipText = fileData.Errors;
            }

            FilePreview filePreview = new FilePreview(this, fileData);
            filePreview.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(filePreview);
            filePreviewTabs.TabPages.Add(newTabPage);
        }

        // Load file preview from file path
        private void LoadFilePreview(string filePath)
        {
            filePreviewTabs.TabPages.Clear();
            if (File.Exists(filePath))
            {
                FileData fileData = GetFileDataFromPath(filePath);
                FillFilePreview(fileData);
            }
        }

        private FileData GetFileDataFromPath(string filePath)
        {
            FileData fileData;
            mFileDataMap.TryGetValue(filePath, out fileData);
            if (fileData == null)
            {
                JsonFileData json = new JsonFileData(filePath);
                if (json != null)
                {
                    json.Load();
                    fileData = json.OpenedFiles.First();
                    mFileDataMap[filePath] = fileData;
                }
            }

            return fileData;
        }

        private void effectsEditorTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            object fullPath = effectsEditorTreeView.SelectedNode.Tag;
            if (fullPath != null)
            {
                LoadFilePreview(fullPath.ToString());
            }
            else
            {
                // If no file data found, just clear file preview
                filePreviewTabs.TabPages.Clear();
            }

            effectsEditorTreeView.Focus();
        }

        private void cubemittersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string fullPath = cubemittersTreeView.SelectedNode.Tag as string;
            if (fullPath != null && File.Exists(fullPath))
            {
                LoadFilePreview(fullPath);
                FileData fileData = GetFileDataFromPath(fullPath);
                string jsonString = fileData.FlatFileData;
                JObject json = null;
                try
                {
                    json = JObject.Parse(jsonString);
                }
                catch
                {
                    // TODO: Check if file is an xml and handle that
                    MessageBox.Show("invalid json");
                    filePreviewTabs.TabPages.Clear();
                    return;
                }

                mEffectsChromeBrowser.LoadFromJson("cubemitter", jsonString, j => SaveFile(fullPath, j));
            }
            else
            {
                // If no file data found, just clear file preview
                filePreviewTabs.TabPages.Clear();
                return;
            }

            cubemittersTreeView.Focus();
        }

        private void lightsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string fullPath = lightsTreeView.SelectedNode.Tag as string;
            if (fullPath != null && File.Exists(fullPath))
            {
                LoadFilePreview(fullPath);
                FileData fileData = GetFileDataFromPath(fullPath);
                string jsonString = fileData.FlatFileData;
                JObject json = null;
                try
                {
                    json = JObject.Parse(jsonString);
                }
                catch
                {
                    MessageBox.Show("invalid json");
                    filePreviewTabs.TabPages.Clear();
                    return;
                }

                mEffectsChromeBrowser.LoadFromJson("animatedlight", jsonString, j => SaveFile(fullPath, j));
            }
            else
            {
                // If no file data found, just clear file preview
                filePreviewTabs.TabPages.Clear();
                return;
            }

            lightsTreeView.Focus();
        }

        private void skySettingsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tag = skySettingsTreeView.SelectedNode.Tag;
            string fullPath = null;
            if (tag is string)
            {
                fullPath = tag as string;
            }
            else if (tag is JsonFileData)
            {
                fullPath = (tag as JsonFileData).Path;
            }
            if (fullPath != null && File.Exists(fullPath))
            {
                LoadFilePreview(fullPath);
                FileData fileData = GetFileDataFromPath(fullPath);
                string jsonString = fileData.FlatFileData;
                JObject json = null;
                try
                {
                    json = JObject.Parse(jsonString);
                }
                catch
                {
                    MessageBox.Show("invalid json");
                    filePreviewTabs.TabPages.Clear();
                    return;
                }

                mEffectsChromeBrowser.LoadFromJson("sky", jsonString, j => SaveFile(fullPath, j));
            }
            else
            {
                // If no file data found, just clear file preview
                filePreviewTabs.TabPages.Clear();
                return;
            }

            skySettingsTreeView.Focus();
        }

        private void effectsEditorTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            effectsEditorTreeView.SelectedNode = effectsEditorTreeView.GetNodeAt(e.X, e.Y);
            mSelectedNode = effectsEditorTreeView.SelectedNode;
            CheckShowContextMenu(effectsEditorTreeView, e);
        }

        private void cubemittersTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            cubemittersTreeView.SelectedNode = cubemittersTreeView.GetNodeAt(e.X, e.Y);
            mSelectedNode = cubemittersTreeView.SelectedNode;
            CheckShowContextMenu(cubemittersTreeView, e);
        }

        private void lightsTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            lightsTreeView.SelectedNode = lightsTreeView.GetNodeAt(e.X, e.Y);
            mSelectedNode = lightsTreeView.SelectedNode;
            CheckShowContextMenu(lightsTreeView, e);
        }

        private void skySettingsTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            skySettingsTreeView.SelectedNode = skySettingsTreeView.GetNodeAt(e.X, e.Y);
            mSelectedNode = skySettingsTreeView.SelectedNode;
            CheckShowContextMenu(skySettingsTreeView, e);
        }

        private void CheckShowContextMenu(TreeView treeView, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                effectsEditorContextMenuStrip.Show(treeView, new Point(e.X, e.Y));
            }
        }

        private void SaveFile(string path, string json)
        {
            File.WriteAllText(path, json);
            mFileDataMap.Remove(path);
            this.Invoke(new MethodInvoker(() => LoadFilePreview(path)));
        }

        private TreeView GetTreeView(int index)
        {
            switch (index)
            {
                case 0:
                    return cubemittersTreeView;
                case 1:
                    return lightsTreeView;
                case 2:
                    return effectsEditorTreeView;
                case 3:
                    return skySettingsTreeView;
                default:
                    return effectsEditorTreeView;
            }
        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView treeView = GetTreeView(treeViewTabControl.SelectedIndex);
            TreeNode selectedNode = treeView.SelectedNode;
            string filePath = selectedNode.Tag != null ? selectedNode.Tag.ToString() : null;

            if (filePath == null)
            {
                MessageBox.Show("Invalid effect file!");
                return;
            }

            FileData selectedFileData = GetFileDataFromPath(filePath);
            char separator = '\\';
            if (!selectedNode.FullPath.Contains('\\'))
            {
                // For cubemitters the paths were being retrieved as filepaths, not nodepaths
                // so do this to retrieve the source mod name correctly
                separator = '/';
            }
            string sourceModName = selectedNode.FullPath.Split(separator)[0];
            CloneEffectFileCallback callback = new CloneEffectFileCallback(this, selectedFileData);
            CloneDialog dialog = new CloneDialog(selectedFileData.FileName, selectedFileData.GetNameForCloning(), sourceModName);
            dialog.SetCallback(callback);
            dialog.ShowDialog();
        }

        private void SetNewFilePath(string newFilePath)
        {
            mNewFilePath = newFilePath;
        }

        public void newFileButton_Click(object sender, EventArgs e)
        {
            if (mSelectedNode != null)
            {
                string path = mSelectedNode.Tag != null ? JsonHelper.NormalizeSystemPath(mSelectedNode.Tag.ToString()) : null;
                if (path != null)
                {
                    saveEffectsFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(path);
                }
            }
            else
            {
                saveEffectsFileDialog.InitialDirectory = System.IO.Path.GetFullPath(ModuleDataManager.GetInstance().ModsDirectoryPath);
            }

            saveEffectsFileDialog.ShowDialog();
            saveEffectsFileDialog.RestoreDirectory = true;
        }

        private void saveEffectsFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string directory = System.IO.Path.GetFullPath(saveEffectsFileDialog.FileName);
            using (StreamWriter wr = new StreamWriter(directory, false, new UTF8Encoding(false)))
            {
                wr.Write("{\n\n}");
            }

            mNewFilePath = JsonHelper.NormalizeSystemPath(directory);
            Reload();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info: Right click an effect in the list to clone an effect. \n" +
                            "Warning: Cloning aliases not yet supported. \n");
        }

        private void cefDevToolsButton_Click(object sender, EventArgs e)
        {
            mEffectsChromeBrowser.ShowDevTools();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mEffectsChromeBrowser.Refresh();
        }

        // TODO: Refactor dialog/callback code so this isn't copy pasted from manifest view classes
        private class CloneEffectFileCallback : CloneDialog.IDialogCallback
        {
            private FileData mFileData;
            private EffectsEditorView mViewer;
            private PreviewCloneFileCallback mPreviewCallback;

            public CloneEffectFileCallback(EffectsEditorView viewer, FileData file)
            {
                mViewer = viewer;
                mFileData = file;
            }

            public void OnCancelled()
            {
                // Do nothing. user cancelled
            }

            public bool OnAccept(CloneObjectParameters parameters)
            {
                // Do the cloning
                string originalName = mFileData.GetNameForCloning();
                string potentialNewNodeName = parameters.TransformParameter(originalName);
                if (potentialNewNodeName.Length <= 1)
                {
                    MessageBox.Show("You must enter a name longer than 1 character for the clone!");
                    return false;
                }

                if (potentialNewNodeName.Equals(originalName))
                {
                    MessageBox.Show("You must enter a new unique name for the clone!");
                    return false;
                }

                HashSet<string> dependencies = ModuleDataManager.GetInstance().PreviewCloneDependencies(mFileData, parameters);
                HashSet<string> savedUnwantedItems = mPreviewCallback != null ? mPreviewCallback.GetSavedUnwantedItems() : null;
                mPreviewCallback = new PreviewCloneFileCallback(mViewer, mFileData, parameters);
                mPreviewCallback.SetUnwantedItems(savedUnwantedItems);
                PreviewCloneDialog dialog = new PreviewCloneDialog("Creating " + potentialNewNodeName, dependencies, mPreviewCallback);
                DialogResult result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return false;
                }

                return true;
            }
        }

        private class PreviewCloneFileCallback : PreviewCloneDialog.IDialogCallback
        {
            private FileData mFileData;
            private EffectsEditorView mViewer;
            private CloneObjectParameters mParameters;
            private HashSet<string> savedUnwantedItems;
            private string newFilePath;

            public PreviewCloneFileCallback(EffectsEditorView viewer, FileData fileData, CloneObjectParameters parameters)
            {
                mViewer = viewer;
                mFileData = fileData;
                mParameters = parameters;
            }

            public void OnCancelled(HashSet<string> unwantedItems)
            {
                // Do nothing. user cancelled
                savedUnwantedItems = unwantedItems;
            }

            public bool OnAccept(HashSet<string> unwantedItems)
            {
                if (ModuleDataManager.GetInstance().ExecuteClone(mFileData, mParameters, unwantedItems))
                {
                    newFilePath = mParameters.TransformParameter(mFileData.Path);
                    mViewer.SetNewFilePath(newFilePath);
                    mViewer.Reload();
                }

                return true;
            }

            public HashSet<string> GetSavedUnwantedItems()
            {
                return savedUnwantedItems;
            }

            public void SetUnwantedItems(HashSet<string> items)
            {
                savedUnwantedItems = items;
            }
        }
    }
}
