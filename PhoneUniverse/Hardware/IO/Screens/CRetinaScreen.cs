using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Screens{
    public class CRetinaScreen : CScreenBase
    {
        public override void Display(IScreenImage img)
        {

        }
        public override string ToString()
        {
            return string.Format("Retina-type screen.");
        }

        protected override screenColorScheems ColorScheem { get; }
    }
}
