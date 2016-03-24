namespace StonehearthEditor
{
   partial class EffectsEditorView
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.effectsSplitContainer = new System.Windows.Forms.SplitContainer();
         this.effectsEditorListView = new System.Windows.Forms.ListView();
         this.newFileButton = new System.Windows.Forms.Button();
         this.effectsSplitContainer2 = new System.Windows.Forms.SplitContainer();
         this.editOptionsListView = new System.Windows.Forms.ListView();
         ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer)).BeginInit();
         this.effectsSplitContainer.Panel1.SuspendLayout();
         this.effectsSplitContainer.Panel2.SuspendLayout();
         this.effectsSplitContainer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer2)).BeginInit();
         this.effectsSplitContainer2.Panel2.SuspendLayout();
         this.effectsSplitContainer2.SuspendLayout();
         this.SuspendLayout();
         // 
         // effectsSplitContainer
         // 
         this.effectsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.effectsSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.effectsSplitContainer.Name = "effectsSplitContainer";
         // 
         // effectsSplitContainer.Panel1
         // 
         this.effectsSplitContainer.Panel1.Controls.Add(this.newFileButton);
         this.effectsSplitContainer.Panel1.Controls.Add(this.effectsEditorListView);
         // 
         // effectsSplitContainer.Panel2
         // 
         this.effectsSplitContainer.Panel2.Controls.Add(this.effectsSplitContainer2);
         this.effectsSplitContainer.Size = new System.Drawing.Size(706, 496);
         this.effectsSplitContainer.SplitterDistance = 204;
         this.effectsSplitContainer.TabIndex = 1;
         // 
         // effectsEditorListView
         // 
         this.effectsEditorListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.effectsEditorListView.Location = new System.Drawing.Point(0, 0);
         this.effectsEditorListView.Name = "effectsEditorListView";
         this.effectsEditorListView.Size = new System.Drawing.Size(204, 496);
         this.effectsEditorListView.TabIndex = 0;
         this.effectsEditorListView.UseCompatibleStateImageBehavior = false;
         // 
         // newFileButton
         // 
         this.newFileButton.Location = new System.Drawing.Point(3, 3);
         this.newFileButton.Name = "newFileButton";
         this.newFileButton.Size = new System.Drawing.Size(198, 33);
         this.newFileButton.TabIndex = 1;
         this.newFileButton.Text = "New Effect File";
         this.newFileButton.UseVisualStyleBackColor = true;
         // 
         // effectsSplitContainer2
         // 
         this.effectsSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.effectsSplitContainer2.Location = new System.Drawing.Point(0, 0);
         this.effectsSplitContainer2.Name = "effectsSplitContainer2";
         // 
         // effectsSplitContainer2.Panel2
         // 
         this.effectsSplitContainer2.Panel2.Controls.Add(this.editOptionsListView);
         this.effectsSplitContainer2.Size = new System.Drawing.Size(498, 496);
         this.effectsSplitContainer2.SplitterDistance = 304;
         this.effectsSplitContainer2.TabIndex = 0;
         // 
         // editOptionsListView
         // 
         this.editOptionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.editOptionsListView.Location = new System.Drawing.Point(0, 0);
         this.editOptionsListView.Name = "editOptionsListView";
         this.editOptionsListView.Size = new System.Drawing.Size(190, 496);
         this.editOptionsListView.TabIndex = 0;
         this.editOptionsListView.UseCompatibleStateImageBehavior = false;
         // 
         // EffectsEditorView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.effectsSplitContainer);
         this.Name = "EffectsEditorView";
         this.Size = new System.Drawing.Size(706, 496);
         this.effectsSplitContainer.Panel1.ResumeLayout(false);
         this.effectsSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer)).EndInit();
         this.effectsSplitContainer.ResumeLayout(false);
         this.effectsSplitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer2)).EndInit();
         this.effectsSplitContainer2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer effectsSplitContainer;
      private System.Windows.Forms.Button newFileButton;
      private System.Windows.Forms.ListView effectsEditorListView;
      private System.Windows.Forms.SplitContainer effectsSplitContainer2;
      private System.Windows.Forms.ListView editOptionsListView;
   }
}
