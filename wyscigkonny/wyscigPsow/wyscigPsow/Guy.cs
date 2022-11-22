﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace wyscigPsow
{
    public class Guy
    {
        public string Name;
        public Bet Mybet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy()
        {
            Mybet = new Bet();
        }
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " ma " + Cash;
        }
        public void ClearBet()
        {
            Mybet.Amount = 0;
        }
        public bool PlaceBet(int Amount,int DogToWin)
        {
            Mybet.Amount = Amount;
            Mybet.Dog = DogToWin;
            Mybet.Bettor = this;

            if (Cash > Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Collect(int Winner)
        {
            Cash += Mybet.PayOut(Winner);
        }

    }
}
