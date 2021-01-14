using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedPartyPlanner
{
    class Party
    {
        public const decimal costOfFoodPerPerson = 25.00M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CalculateCostOfDecorations() 
        { 
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            return costOfDecorations;
        }

        virtual public decimal Cost 
        { 
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += costOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100.00M;

                return totalCost;
            }
        }
         
    }
}
