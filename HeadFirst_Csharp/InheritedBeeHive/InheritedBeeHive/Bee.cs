using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedBeeHive
{
    class Bee
    {
        public const double honeyUnitConsumedPerMg = 0.25;

        public double WeightMg { get; private set; }

        public Bee (double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double honeyConsumptionRate()
        {
            return WeightMg * honeyUnitConsumedPerMg;
        }
    }
}
