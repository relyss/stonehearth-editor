using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace StonehearthEditor.Effects
{
   public sealed class OriginProperty : Property
   {
      public override string Name
      {
         get
         {
            return "origin";
         }
      }

      public override PropertyValue FromJson(JToken json)
      {
         throw new NotImplementedException();
      }

      public override JToken ToJson(PropertyValue value)
      {
         throw new NotImplementedException();
      }
   }

   public sealed class OriginPropertyValue : PropertyValue
   {
      private bool isMissing;
      public string Surface { get; set; }

      public override bool IsMissing
      {
         get
         {
            return this.isMissing;
         }
      }

      public void SetIsMissing(bool value)
      {
         this.isMissing = value;
      }
   }
}
