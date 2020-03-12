using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{
    enum stufftype
    {
        PB,LIION, POLYMERIC
    }
    enum capMesurement{
        MILLIAH
    }

    class CBattery
    {
        public CBattery()
        {
            removable=false;
        }
        public override string ToString()
        {
            return string.Format("type is {0}",type);
        }
        private float sizex;
        private float sizey;
        private float sizez;
        private float weight;
        private stufftype type;
        private int volume;
        private capMesurement capMesure;
        private bool removable;
    }
}
