using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStingPatrol
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get { throw new NotImplementedException(); }
        }

        public int StingerLength
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }
    }
}
