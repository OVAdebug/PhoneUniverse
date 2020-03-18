using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Screens{           

    public class COLEDScreen:CScreenBase
    {
        public COLEDScreen()
        {
            ColorScheem = screenColorScheems.COLORED32K;
        }
        public COLEDScreen(int x, int y)
        {
            PixelsAlongHor = x;
            PixelsAlongVert = y;
            ColorScheem = screenColorScheems.COLORED32K;
            hassensore = true;
        }
        public override void Display(IScreenImage img)
        {

        }
        public override string ToString()
        {
            string s = string.Format("OLED Screen's resolution: {0}x{1}", PixelsAlongHor, PixelsAlongVert);
            if (hassensore)
            {
                s += ", touch screen";
            }
            else
            {
                s += ", without sensor";
            }
            s +=", " +"Color scheem is " + ColorScheem.ToString();
            return s;
        }
        
        private int size;
        private int PixelsAlongHor { get; }
        private int PixelsAlongVert { get; }
        protected override screenColorScheems ColorScheem{ get; }
        private bool hassensore;
    }
}
