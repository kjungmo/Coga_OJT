using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Locksmith
    {
        public void openSafe(Safe safe, Owner owner)
        {
            safe.pickLock(this);
            Jewels safeContents = safe.open(writtenDownCombination);
            returnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;

        public void writeDownCombination ( string combination)
        {
            writtenDownCombination = combination;
        }

        public virtual void returnContents(Jewels safeContents, Owner owner)
        {
            owner.receiveContents(safeContents);
        }
    }
}
