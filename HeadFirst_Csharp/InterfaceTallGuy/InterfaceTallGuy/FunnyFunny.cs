using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTallGuy
{
    class FunnyFunny : IClown
    {
        public FunnyFunny (string funnyThingIHave)
	{
            this.funnyThingIHave = funnyThingIHave;
	}
        public string FunnyThingIHave
        {
            get { return "Hi kids! I have " + funnyThingIHave; }
        }

        public void honk()
        {
            Console.WriteLine(this.funnyThingIHave); ;
        }

        private string funnyThingIHave;
    }
}
