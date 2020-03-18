using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUniverse{
    class Program
    {
        static void Main(string[] args)
        {
            CSimCorpMobile cphone = new CSimCorpMobile();
            Console.WriteLine("Info: "+cphone.ToString());
            Console.ReadLine();
        }
    }
}
