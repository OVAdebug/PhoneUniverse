using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{    
        public enum  screenColorSceem
        {
            MONOCHROME, COLORED256, COLORED32K

        }
    public interface IScreenImage
    {
         int pixelsAlongHor { get; }
         int pixelsAlongVert { get; }
        screenColorSceem colorScheem { get; }

    }
    public abstract class CScreenBase
    {

        public abstract void Display(IScreenImage img);
    }

    public class MonochromeScreen: CScreenBase
    {
        public override void  Display(IScreenImage img)
        {

        }
}
    public class ColorfulScreen : CScreenBase
    {
        public override void Display(IScreenImage img)
        {

        }
    }

    public class COLEDScreen:ColorfulScreen 
    {
        public COLEDScreen()
        {

        }
        public COLEDScreen(int x, int y)
        {
            pixelsAlongHor = x;
            pixelsAlongVert = y;
            colorScheem = screenColorSceem.COLORED32K;
            hassensore = true;
        }
        public override void Display(IScreenImage img)
        {

        }
        public override string ToString()
        {
            string s = string.Format("OLED Screen's resolution: {0}x{1}", pixelsAlongHor, pixelsAlongVert);
            if (hassensore)
            {
                s += ", touch";
            }
            else
            {
                s += ", without sensor";
            }
            s +=", " +"Color scheem is " + colorScheem.ToString();

            return s;
        }
        
        private int size;
        private int pixelsAlongHor { get; }
        private int pixelsAlongVert { get; }
        private screenColorSceem colorScheem { get; }
        private bool hassensore;

    }

    public class CRetinaScreen : ColorfulScreen
    {
        public override void Display(IScreenImage img)
        {

        }
    }
    
}
