using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonehearthEditor
{
   // tell you what types are valid
   // put range limits in constructor
   abstract class Giver { }

   sealed class FloatGiver : Giver
   {
      private float? min;
      private float? max;
   }

   public partial class EffectComponentsEditor : UserControl
   {
      // topic => parameter => param info
      private readonly Dictionary<string, Dictionary<string, Giver>> particleOptions = new Dictionary<string, Dictionary<string, Giver>>
      {
         {
            "speed", new Dictionary<string, Giver>
         {
            {"start", new FloatGiver() },
            {"over_lifetime_x", new FloatGiver() }
         } }
      };

      public EffectComponentsEditor()
      {
         InitializeComponent();
      }
   }
}
