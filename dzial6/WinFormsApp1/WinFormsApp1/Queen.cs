﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Queen
    {
        public Queen(Workers[] workers)
        {
            this.workers = workers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;
        public bool AssignWork(string job, int numberOfShifts)
        {
            for(int i=0; i < workers.Length; i++)           
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
                return false;            
        }
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Raport zmiany numer " + shiftNumber + "\r\n";
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Robotnica nr " + (i + 1) + " zakonczyla swoje zadanie\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Robotnica nr " + (i + 1) + " nie pracuje\r\n";
                else
                    if (workers[i].ShiftLeft > 0)
                    report += "Robotnica numer " + (i + 1) + " robi " + workers[i].CurrentJob + "jeszcze przez " + workers[i].ShiftLeft + " zmiany\r\n";
                else
                    report += "Robotnica numer " + (i + 1) + " zakonczy " + workers[i].CurrentJob + "po tej zmiany \r\n";
            }
            return report;
        }
    }
}
