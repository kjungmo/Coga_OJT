using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cowCalculator
{
    class Farmer
    {
        
        private int feedMultiplier;
        public int publicFeedMultiplier
        {
            get
            {
                return feedMultiplier;
            }
            set
            {

            }
        }
        private int bagsOfFeed;
        public int publicBagsOfFeed 
        {
            get
            {
                return bagsOfFeed;
            }
            private set
            {

            }
        }
        private int numberOfCows;
        public int publicNumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                publicBagsOfFeed = numberOfCows * publicFeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            publicNumberOfCows = numberOfCows;
        }
    }
}
