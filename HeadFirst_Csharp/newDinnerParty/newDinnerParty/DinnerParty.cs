using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newDinnerParty
{
    class DinnerParty
    {
        public const decimal costOfFoodPerPerson = 25M;
        public int publicNumberOfPeople { get; set; }
        public bool publicFancyDecorations { get; set; }
        public bool publicHealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            publicNumberOfPeople = numberOfPeople;
            publicFancyDecorations = fancyDecorations;
            publicHealthyOption = healthyOption;
        }

        private decimal calculateCostOfDecorations() 
        {
            decimal costOfDecorations;
            if(publicFancyDecorations)
            {
                costOfDecorations = 50M + (publicNumberOfPeople * 15M);
            }
            else
            {
                costOfDecorations = 30M + (publicNumberOfPeople * 7.5M);
            }
            return costOfDecorations;
            
        }
        private decimal calculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragePerPerson;
            if(publicHealthyOption)
            {
                costOfBeveragePerPerson = 5M;
            }
            else
            {
                costOfBeveragePerPerson = 20M;
            }
            return costOfBeveragePerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = calculateCostOfDecorations() + ((costOfFoodPerPerson + calculateCostOfBeveragesPerPerson()) * publicNumberOfPeople);
                if (publicHealthyOption)
                {
                    totalCost = totalCost * (1M - 0.05M);
                }
                return totalCost;
            }
        }
    }
}
