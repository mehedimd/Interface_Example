using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Horse: ILandBound, IJourney
    {
        int ILandBound.NumberOfLegs()
        {
            return 500;
        }
         int IJourney.NumberOfLegs()
        {
            return 600;
        }
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            ILandBound ilb = horse;
            int x = ilb.NumberOfLegs();
            Console.WriteLine(x);

            IJourney journey = horse;
            int y = journey.NumberOfLegs();
            Console.WriteLine(y);  

            Console.ReadKey();
            
        }
    }
}
