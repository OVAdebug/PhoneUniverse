using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.Peripheral{    
    class CMicrophone
    {        
        private double LowFreq;
        private double UperFreq;
        private double bitrate;

        public override string ToString()
        {
            return string.Format("Mic. equipment exists");
        }
    }
}
