using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTallGuy
{
    class Program
    {
        class TallGuy : IClown
        {
            public string name;
            public int height;
            public void talkAboutYourself()
            {
                Console.WriteLine("My name is " + name + " and I'm " + height + " inches tall.");
            }

            public string FunnyThingIHave
            {
                get
                {
                    return "big shoes";
                }
            }

            public void honk()
            {
                Console.WriteLine("Honk honk!");
            }
        }
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { height = 74, name = "Jimmy" };
            tallGuy.talkAboutYourself();
            tallGuy.honk();
            Console.ReadKey();
        }
    }
}
