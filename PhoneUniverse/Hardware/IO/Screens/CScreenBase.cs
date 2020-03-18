using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.IO.Screens{
    public enum screenColorScheems
    {
        MONOCHROME, COLORED256, COLORED32K
    }
    public interface IScreenImage
    {
        int PixelsAlongHor { get; }
        int PixelsAlongVert { get; }
        screenColorScheems ColorScheem { get; }
    }
    public abstract class CScreenBase
    {
        public abstract void Display(IScreenImage img);

        protected abstract screenColorScheems ColorScheem { get; }
    }
}
