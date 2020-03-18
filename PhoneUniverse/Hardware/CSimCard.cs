using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware{
    public class CSimCard : CSimpleSimCard
    {
        public CSimCard()
        {
            CardType = SimCardTypes.MICRO;
        }
        
        public override string ToString()
        {
            return string.Format($"card's type - {CardType.ToString()}");
        }
    }
}
