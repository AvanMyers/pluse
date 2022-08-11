using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 5;
            int addedNumber = 7;
            int stopNumber = 100;

            for (int i = startingNumber; i <= stopNumber; i += addedNumber)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
