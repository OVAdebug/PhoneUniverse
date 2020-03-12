using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse
{
    public enum SimCardType
    {
        PLAIN,MINI,MICRO
    }
 
    public interface ISimCard
    {
        int cardlots{get;}
         List<SimCardType> simCards { get; }
    }

    public abstract class CSimpleSimCard
    {
        
        protected SimCardType cardType;
        public abstract void Display(ISimCard cards);
                
    }
    public class CSimCard : CSimpleSimCard
    {
        public CSimCard()
        {

            simCards = new List<SimCardType>();
        }
        public CSimCard(int n)
        {

            simCards = new List<SimCardType>();
            for (int i=0;i<n;i++)
                simCards.Add(SimCardType.MICRO);

        }
        public override  void Display(ISimCard cards)
        {
            
        }
        public override string ToString()
        {
            string s=string.Format("Number of cards supported: {0}", cardlots);
            return s;
        }

        public int cardlots { get { return simCards.Count; } }
        public List<SimCardType> simCards { get; }
    }
}
