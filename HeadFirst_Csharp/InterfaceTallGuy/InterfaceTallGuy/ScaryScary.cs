using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTallGuy
{
    class ScaryScary : FunnyFunny, IScaryClown 
    {
        public ScaryScary(int numberOfScaryThings, string funnyThingIHave) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;

        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders"; }
        }

        public void scareLittleChildren()
        {
            Console.WriteLine("You can't have my " + base.funnyThingIHave);
        }
    }
}
