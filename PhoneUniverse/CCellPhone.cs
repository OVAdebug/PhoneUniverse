using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{
    public abstract class CCellPhone
    {

        public CCellPhone()
        {
            this.dynamic = new CDynamic();
            this.mic = new CMicrophone();
            this.battery = new CBattery();
        
        }

        public string GetDescription()
        {
        var descriptionBuilder = new StringBuilder();
        descriptionBuilder.AppendLine($"Screen Type: {screen.ToString()}.");
        descriptionBuilder.AppendLine($"Keyboard Type: {keyb.ToString()}.");
        descriptionBuilder.AppendLine($"Simcard number: {simCard.ToString()}.");
        descriptionBuilder.AppendLine($"Speakers: {dynamic.ToString()}.");
            descriptionBuilder.AppendLine($"Microphone: {mic.ToString()}.");
            descriptionBuilder.AppendLine($"Battery: {battery.ToString()}.");
            return descriptionBuilder.ToString();
        }

        public abstract CScreenBase screen { get; }
        public abstract CBasicKeyboard keyb { get; }
        public abstract CSimpleSimCard simCard { get; }
        private CBattery battery;
        
        private CDynamic dynamic;
        private CMicrophone mic;
    }
    public class CSimCorpMobile : CCellPhone
    {
        
        public override CScreenBase screen { get { return vOLEDScreen; } }
        private readonly COLEDScreen vOLEDScreen = new COLEDScreen(300,400);

        public override CBasicKeyboard keyb {get {return vkeyb;}}
        private readonly  CSensoredKeyboard  vkeyb= new CSensoredKeyboard();

        public override CSimpleSimCard simCard { get { return vcards; } }
        private readonly CSimCard vcards = new CSimCard(2);
    }


}
