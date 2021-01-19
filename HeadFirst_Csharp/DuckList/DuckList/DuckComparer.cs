using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria sortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (sortBy == SortCriteria.SizeThenKind)
                if (x.size > y.size)
                    return 1;
                else if (x.size < y.size)
                    return -1;
                else
                    if (x.kind > y.kind)
                        return 1;
                    else if (x.kind < y.kind)
                        return -1;
                    else
                        return 0;
            else
                if (x.kind > y.kind)
                    return 1;
                else if (x.kind < y.kind)
                    return -1;
                else
                    if (x.size > y.size)
                        return 1;
                    else if (x.size < y.size)
                        return -1;
                    else
                        return 0;
        }
    }
}
