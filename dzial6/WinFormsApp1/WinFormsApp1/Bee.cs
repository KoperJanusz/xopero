using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Bee : IStingPatrol
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
        public int AlertLevel { get; }
        public int StingerLenght { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int Lenght)
        {
        return 0;}
        }
}
