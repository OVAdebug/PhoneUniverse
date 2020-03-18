using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneUniverse.Hardware;
using PhoneUniverse.Hardware.IO;
using PhoneUniverse.Hardware.IO.Keyboards;
using PhoneUniverse.Hardware.IO.Screens;
using PhoneUniverse.Hardware.Peripheral;

namespace PhoneUniverse
{
    public class CSimCorpMobile : CCellPhone
    {
        public CSimCorpMobile()
        {
        }
        public override CScreenBase screen { get { return vOLEDScreen; } }
        private readonly COLEDScreen vOLEDScreen = new COLEDScreen(300, 400);

        public override CBasicKeyboard keyb { get { return vkeyb; } }
        private readonly CSensoredKeyboard vkeyb = new CSensoredKeyboard();

        public override CSimpleSimCard simCard { get { return vcards; } }
        private readonly CSimCard vcards = new CSimCard();
    }
}
