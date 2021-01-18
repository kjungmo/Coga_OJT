using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() 
            {
                new Duck() {kind = KindOfDuck.Mallard, size = 17},
                new Duck() {kind = KindOfDuck.Muscovy, size = 18},
                new Duck() {kind = KindOfDuck.Decoy, size = 14},
                new Duck() {kind = KindOfDuck.Muscovy, size = 11},
                new Duck() {kind = KindOfDuck.Mallard, size = 14},
                new Duck() {kind = KindOfDuck.Decoy, size = 13},
            };

            Console.ReadKey();
        }
    }
}
