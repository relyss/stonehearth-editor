using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StonehearthEditor.subViews;
using Newtonsoft.Json.Linq;
using StonehearthEditor.Effects;
using StonehearthEditor.EffectsUI;

namespace StonehearthEditor
{
   public partial class EffectsBuilderView : UserControl
   {
      private Control editorUI;

      public EffectsBuilderView()
      {
         InitializeComponent();
      }

      public void ReloadEditor(JToken json, Property property)
      {
         if (editorUI != null)
         {
            pnlEditor.Controls.Remove(editorUI);
            editorUI.Dispose();
            editorUI = null;
         }

         PropertyValue propertyValue = property.FromJson(json);
         editorUI = EffectUICreator.CreateUI(property, propertyValue);
         pnlEditor.Controls.Add(editorUI);
      }

      public void UpdateBuilder(TreeView treeView, TabControl filePreviewTabs, string effectType)
      {
         switch(effectType)
         {
            case "cubemitter":
               CubemitterInputView civ = new CubemitterInputView();
               civ.ParticleFlowPanel.Controls.Add(new EffectInputView());
               civ.EmissionFlowPanel.Controls.Add(new EffectInputView());
               effectsBuilderPanel.Controls.Add(civ);
               break;
            default:
               // do nothing
               break;
         }
      }


   }
}
