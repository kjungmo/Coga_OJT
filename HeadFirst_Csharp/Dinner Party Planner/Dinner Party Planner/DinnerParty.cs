using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party_Planner
{
    public class DinnerParty
    {
        private int numberOfPeople;
        public decimal costOfBeveragesPerPerson;
        public decimal costOfDecorations;
        public const decimal costOfFoodPerPerson = 25M;

        public void setPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            calculateCostOfDecorations(fancy);
        }

        public int getNumberOfPeople()
        {
            return numberOfPeople;
        }

        public void setHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                costOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.0M;
            }
        }

        public void calculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                costOfDecorations = 50M + ( numberOfPeople * 15M );
            }
            else
            {
                costOfDecorations = 30M + ( numberOfPeople * 7.5M );
            }
        }
        
        public decimal calculateCost(bool healthyOption)
        {
            decimal totalCost = costOfDecorations + ((costOfFoodPerPerson + costOfBeveragesPerPerson) * numberOfPeople );

            if (healthyOption)
            {
                return totalCost * (1M - 0.05M);
            }
            else
            {
                return totalCost;
            }
        }
    }
}
