using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.kind < y.kind)
                return -1;
            if (x.kind > y.kind)
                return 1;
            else
                return 0;
        }
    }
}
