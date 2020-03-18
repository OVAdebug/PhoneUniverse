using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Keyboards{
    public abstract class CBasicKeyboard
    {
        protected enum Layouts
        {
            FIGURES, QUERTY, SMART
        }
        public CBasicKeyboard()
        {
            kblout = Layouts.FIGURES;
        }

        protected Layouts kblout;
    }
}
