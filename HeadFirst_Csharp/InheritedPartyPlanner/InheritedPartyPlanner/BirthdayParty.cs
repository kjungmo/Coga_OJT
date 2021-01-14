using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedPartyPlanner
{
    class BirthdayParty : Party
    {
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public string CakeWriting { get; set; }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > maxWritingLength())
                    return maxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int maxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public bool CakeWritingTooLong 
        { 
            get
            {
                if (CakeWriting.Length > maxWritingLength())
                    return true;
                else 
                    return false;
            }
        }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40.00M + ActualLength * 0.25M;
                else
                    cakeCost = 75.00M + ActualLength * 0.25M;
                return totalCost + cakeCost;
            }
        }

    }
}
