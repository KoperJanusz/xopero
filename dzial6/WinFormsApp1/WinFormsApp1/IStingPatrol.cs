using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLenght { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Lenght);
    }
}
