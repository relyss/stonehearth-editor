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

namespace StonehearthEditor
{
   public partial class EffectsBuilderView : UserControl
   {
      abstract class Giver { }
      sealed class FloatGiver : Giver
      {
         private float? min;
         private float? max;

         public FloatGiver(string option)
         {
         }
      }

      // topic => parameter => param info
      private readonly Dictionary<string, Dictionary<string, Giver>> particleOptions = new Dictionary<string, Dictionary<string, Giver>>
      {
         {
            "speed", new Dictionary<string, Giver>
            {
               { "start", new FloatGiver("start") },
               { "over_lifetime", new FloatGiver("over_lifetime") }
            }
         },
         {
            "lifetime", new Dictionary<string, Giver>
            {
               { "start", new FloatGiver("start") }
            }
         }
      };
      public EffectsBuilderView()
      {
         InitializeComponent();
      }

      public void Initialize()
      {
         // initialize view variables
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
