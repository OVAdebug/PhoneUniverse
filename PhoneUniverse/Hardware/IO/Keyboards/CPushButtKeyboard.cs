using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Keyboards{  
    class CPushButtKeyboard : CBasicKeyboard
    {
        public CPushButtKeyboard()
        {
            kblout = Layouts.QUERTY;
        }
        public override string ToString()
        {
            string s = string.Format("Keybord has layout {0}", kblout.ToString());
            return s;
        }   
    }
}
