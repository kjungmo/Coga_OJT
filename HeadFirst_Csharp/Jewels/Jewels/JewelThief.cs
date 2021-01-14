using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewls = null;
        override public void returnContents(Jewels safeContents, Owner owner)
        {
            stolenJewls = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewls.sparkle());
        }
    }
}
