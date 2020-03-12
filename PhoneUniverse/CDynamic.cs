using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{
    public class CDynamic
    {
        public CDynamic()
        {
            quantity=1;
        }
        public override string ToString()
        {
            string s=base.ToString();
            s += string.Format("Number of speakers: {0}",quantity);
            return s;
        }
        private int quantity;
        private double lowFreq;
        private double uperFreq;

    }
}
