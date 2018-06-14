using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
    class Targets
    {
        public static string[] getTargets()
        {
            var targets = Enum.GetNames(typeof(targetsEnum));
            return targets;
        }

        enum targetsEnum
        {
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10
        };
    }
}
