using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace wyscigPsow
{
    class Greyhound
    {
        public int StarttingPosition;
        public int Racetracklenght;
        public PictureBox MyPictureBox=null;
        public int Location = 0;
        public Random Randomizer;
        
        
        public Greyhound(PictureBox MyPictureBox, int startingpositon, int racetracklenght)
        {
            this.MyPictureBox = MyPictureBox;
            this.StarttingPosition = startingpositon;
            this.Racetracklenght = racetracklenght;
            Randomizer = new Random();
            
        }
        public bool Run()
        {

            Location += Randomizer.Next(1, 4);
            MyPictureBox.Left = StarttingPosition + Location;
            

            if (Location >= Racetracklenght)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            
            MyPictureBox.Left = StarttingPosition;
            Location = 0;
        }
    }
}
