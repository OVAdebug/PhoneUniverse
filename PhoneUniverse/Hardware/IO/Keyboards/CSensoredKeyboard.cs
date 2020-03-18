using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Keyboards{
    class CSensoredKeyboard : CBasicKeyboard
    {
        public CSensoredKeyboard()
        {
            sensory = true;
            kblout = Layouts.QUERTY;
        }
        public override string ToString()
        {
            string s = string.Format("Keybord is {0}", sensory ? "sensory" : "non-sensory.");
            s += ", ";
            s += string.Format("has layout {0}", kblout.ToString());
            return s;
        }

        private bool sensory;
    }
}
