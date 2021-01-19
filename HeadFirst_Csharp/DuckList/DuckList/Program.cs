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

            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            DuckComparerByKind kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            DuckComparer comparer1 = new DuckComparer();
            comparer1.sortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer1);
            PrintDucks(ducks);

            DuckComparer comparer2 = new DuckComparer();
            comparer2.sortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer2);
            PrintDucks(ducks);

            //ducks.Sort();
            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of Ducks!");
        }
    }
}
