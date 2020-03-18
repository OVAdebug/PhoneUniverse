using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware{
    public enum SimCardTypes
    {
        PLAIN, MINI, MICRO
    }

    public abstract class CSimpleSimCard
    {
        protected SimCardTypes CardType;
    }
}
