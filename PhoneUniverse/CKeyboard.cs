using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{
    public abstract class CBasicKeyboard
    {
        protected enum Layout
        {
            FIGURES, QUERTY, SMART
        }
        public CBasicKeyboard()
        {            
            kblout = Layout.FIGURES;
        }
       
        protected Layout kblout;
    }

    class CPushButtKeyboard : CBasicKeyboard
    {
        public CPushButtKeyboard()
        {
           
            kblout = Layout.QUERTY;
        }
        public override string ToString()
        {
            string s = string.Format("Keybord has layout {0}", kblout.ToString());
            return s;
        }
        
    }

    class CSensoredKeyboard : CBasicKeyboard
    {
        public CSensoredKeyboard()
        {
            sensory = true;
            kblout = Layout.QUERTY;        
        }
        public override string ToString()
        {
            string s=string.Format("Keybord is {0}",sensory?"sensory":"non-sensory." );
            s += " ";
            s += string.Format("Keybord has layout {0}", kblout.ToString());
            return s;
        }
        private bool sensory;       
    }
}
