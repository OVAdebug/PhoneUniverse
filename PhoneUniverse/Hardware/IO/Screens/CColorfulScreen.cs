using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Screens{
    public class ColorfulScreen : CScreenBase
    {
        ColorfulScreen()
        {
            ColorScheem = screenColorScheems.COLORED32K;
        }
        public override void Display(IScreenImage img)
        {
        }
        protected override screenColorScheems ColorScheem { get; }
    }
}
