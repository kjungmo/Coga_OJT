using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTallGuy
{
    class Program
    {

        static void Main(string[] args)
        {

            ScaryScary fingersTheClown = new ScaryScary(14, "big shoes");
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.honk();
            someOtherScaryClown.scareLittleChildren();
            Console.WriteLine(someOtherScaryClown.ScaryThingIHave);
            Console.ReadKey();
        }
    }
}
