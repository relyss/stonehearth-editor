using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace StonehearthEditor.Effects
{
   public sealed class ParameterProperty : Property
   {
      private readonly string name;

      public ParameterProperty(
         string name,
         int dimensions = 1,
         bool optional = true,
         bool timeVarying = false)
      {
         this.name = name;
         this.Dimensions = dimensions;
         this.Optional = optional;
         this.TimeVarying = timeVarying;
      }

      public int Dimensions { get; private set; }
      public bool Optional { get; private set; }
      public bool TimeVarying { get; private set; }

      public override string Name
      {
         get
         {
            return this.name;
         }
      }

      public override PropertyValue FromJson(JToken json)
      {
         return null;
      }

      public override JToken ToJson(PropertyValue value)
      {
         return null;
      }
   }
}
