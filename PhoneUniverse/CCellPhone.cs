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

namespace PhoneUniverse{
    public abstract class CCellPhone
    {

        public CCellPhone()
        {
            this.dynamic = new CSpeaker();
            this.mic = new CMicrophone();
            this.battery = new CBattery();
            SimCards = new List<CSimCard>();
            SimCards.Add(new CSimCard());
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {screen.ToString()}.");
            descriptionBuilder.AppendLine($"Keyboard Type: {keyb.ToString()}.");
            descriptionBuilder.AppendLine($"Simcard info: {simCard.ToString()}.");
            descriptionBuilder.AppendLine($"Speakers: {dynamic.ToString()}.");
            descriptionBuilder.AppendLine($"Microphone: {mic.ToString()}.");
            descriptionBuilder.AppendLine($"Battery: {battery.ToString()}.");
            descriptionBuilder.AppendLine($"Number of cards supported: {cardlots.ToString()}.");
            return descriptionBuilder.ToString();
        }

        public abstract CScreenBase screen { get; }
        public abstract CBasicKeyboard keyb { get; }
        public abstract CSimpleSimCard simCard { get; }
        private CBattery battery;
        private CSpeaker dynamic;
        private CMicrophone mic;
        public int cardlots { get { return SimCards.Count; } }
        private List<CSimCard> SimCards; 
    }
}
