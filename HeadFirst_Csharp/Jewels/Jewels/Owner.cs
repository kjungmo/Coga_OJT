using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Owner
    {
        private Jewels returnedContents;
        public void receiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + safeContents.sparkle());
        }
    }
}
