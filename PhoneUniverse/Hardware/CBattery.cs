using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse.Hardware{
    enum stufftypes
    {
        PB,LIION, POLYMERIC
    }
    enum capMesurements{
        MILLIAH
    }

    class CBattery
    {
        public CBattery()
        {
            removable=false;
            type = stufftypes.LIION;
        }
        public override string ToString()
        {
            return string.Format("type is {0}",type);
        }

        private float sizex;
        private float sizey;
        private float sizez;
        private float weight;
        private stufftypes type;
        private int volume;
        private capMesurements CapMesure;
        private bool removable;
    }
}
