using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class DinnerParty
    {
        public const decimal costOfFoodPerPerson = 25M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal calculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = 50M + (NumberOfPeople * 15M);
            }
            else
            {
                costOfDecorations = 30M + (NumberOfPeople * 7.5M);
            }
            return costOfDecorations;

        }
        private decimal calculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragePerPerson;
            if (HealthyOption)
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
                decimal totalCost = calculateCostOfDecorations() + ((costOfFoodPerPerson + calculateCostOfBeveragesPerPerson()) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost = totalCost * .95M;
                }
                return totalCost;
            }
        }
    }
}
