using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware.Peripheral{
    public class CSpeaker
    {
        enum soundTypes{
            MONO, STEREO
        }
        public CSpeaker()
        {
            squaltity = soundTypes.STEREO;
            LowFreq = 20;
            UperFreq = 20000;
        }
        public override string ToString()
        {
            var s = string.Format("Sound characteristics: {0}, [{1}-{2}]", squaltity,LowFreq,UperFreq);
            return s;
        }

        private soundTypes squaltity;
        private double LowFreq;
        private double UperFreq;
    }
}
