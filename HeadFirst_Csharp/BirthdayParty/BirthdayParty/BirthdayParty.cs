using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class BirthdayParty
    {
        public const decimal costOfFoodPerPerson = 25.00M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public BirthdayParty (int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int actualLength
        {
            get
            {
                if (CakeWriting.Length > maxWritingLength())
                    return maxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int cakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int maxWritingLength()
        {
            if (cakeSize() == 8)
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

        private decimal calculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            return costOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                if (NumberOfPeople > 12 )
                {
                    decimal totalCost = calculateCostOfDecorations();
                    totalCost += costOfFoodPerPerson * NumberOfPeople;
                    decimal cakeCost;
                    if (cakeSize() == 8)
                        cakeCost = 40.00M + actualLength * .25M;
                    else
                        cakeCost = 75.00M + actualLength * .25M;
                    return totalCost + cakeCost + 100.00M;
                }
                else
                {
                    decimal totalCost = calculateCostOfDecorations();
                    totalCost += costOfFoodPerPerson * NumberOfPeople;
                    decimal cakeCost;
                    if (cakeSize() == 8)
                        cakeCost = 40.00M + actualLength * .25M;
                    else
                        cakeCost = 75.00M + actualLength * .25M;
                    return totalCost + cakeCost;
                }
            }

        }
    }
}
