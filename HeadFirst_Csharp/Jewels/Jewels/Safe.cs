using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            else
                return null;
        }
        public void pickLock(Locksmith lockpicker)
        {
            lockpicker.writeDownCombination(safeCombination);
        }
    }
}
