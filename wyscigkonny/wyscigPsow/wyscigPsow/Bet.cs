using System;
using System.Collections.Generic;
using System.Text;

namespace wyscigPsow
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return this.Bettor.Name+" "+this.Amount+" na psa numer "+this.Dog;
        }
        public int PayOut(int winner)
        {
            if(Dog==winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
            
        }
    }
}
