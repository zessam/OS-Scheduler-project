using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    public class Process
    {
        public double BurstTime, ArrivalTime, WaitingTime, TurnAround, Priority, FinalTime, ID;

        public Process(int id, double bt, double at, double p = 0)
        {
            BurstTime = bt;
            ArrivalTime = at;
            ID = id;
            Priority = p;
        }

        public double calculate_turnaround(double ft, double at)
        {
            double Turnaround = ft - at;
            return Turnaround;
        }
        public double calculate_waiting(double tat, double bt)
        {
            double waitingt = tat - bt;
            return waitingt;
        }
    }
}
