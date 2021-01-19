using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class Duck : IComparable<Duck>
    {
        public int size;
        public KindOfDuck kind;

        public int CompareTo(Duck duckToCompare)
        {
            if (this.size > duckToCompare.size)
                return 1;
            else if (this.size < duckToCompare.size)
                return -1;
            else 
                return 0;
        }

        public override string ToString()
        {
            return "A " + size + " inch " + kind.ToString();
        }
    }
}
