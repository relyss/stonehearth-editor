using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonehearthEditor.Effects
{
   public static class EffectKinds
   {
      public static readonly Property CubeEmitter = new ComplexProperty(null, false,
         new StringProperty("name"),
         new IntProperty("duration"),
         new ComplexProperty("particle", false,
            new ComplexProperty("lifetime", true,
               new ParameterProperty("start", 1)
            ),
            new ComplexProperty("speed", true,
               new ParameterProperty("start", 1),
               new ParameterProperty("over_lifetime", 1, timeVarying: true)
            ),
            new ComplexProperty("acceleration", true,
               new ParameterProperty("over_lifetime_x", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_y", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_z", 1, timeVarying: true)
            ),
            new ComplexProperty("color", true,
               new ParameterProperty("start", 4),
               new ParameterProperty("over_lifetime_a", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_r", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_g", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_b", 1, timeVarying: true)
            ),
            new ComplexProperty("scale", true,
               new ParameterProperty("start", 1),
               new ParameterProperty("over_lifetime", 1, timeVarying: true)
            ),
            new ComplexProperty("rotation", true,
               new ParameterProperty("over_lifetime_x", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_y", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_z", 1, timeVarying: true)
            ),
            new ComplexProperty("velocity", true,
               new ParameterProperty("over_lifetime_x", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_y", 1, timeVarying: true),
               new ParameterProperty("over_lifetime_z", 1, timeVarying: true)
            )
         ),
         new ComplexProperty("emission", false,
               new ParameterProperty("rate", 1, optional: false),
               new ParameterProperty("angle", 1, optional: false),
               new OriginProperty("origin")
         )
       );
   }
}
