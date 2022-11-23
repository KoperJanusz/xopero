using System;
using System.Collections.Generic;
using System.Text;

namespace hermetyzacja1
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public const int CostOfFoodPerPerson = 25;
        public DinnerParty(int numberOfPeople,bool healthyOption,bool fancyDecorations)
        {
            
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;

            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeverages;
            if (HealthyOption)
            {
                costOfBeverages = 5.00M;

            }
            else
            {
                costOfBeverages = 20.00M;
            }
            return costOfBeverages;
        }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
        }
        

    }
}
