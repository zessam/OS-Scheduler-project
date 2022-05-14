
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    public class CScheduler
    {
        public List<Process> ReadyQueue = new List<Process>();

        public List<Process> FCFS()
        {
            double clk = 0;
            double idle;
            var ordReadyQueue = ReadyQueue.OrderBy(proc => proc.ArrivalTime).ToList();
            List<Process> finalprocs = new List<Process>();
            foreach (var proc in ordReadyQueue)
            {
                Process p = new Process(Convert.ToInt32(proc.ID), proc.BurstTime, proc.ArrivalTime, proc.Priority);
                if (clk >= proc.ArrivalTime)
                {
                    clk += proc.BurstTime;
                    p.FinalTime = Convert.ToInt32(clk);
                    p.TurnAround = p.calculate_turnaround(p.FinalTime, p.ArrivalTime);
                    p.WaitingTime = p.calculate_waiting(p.TurnAround, p.BurstTime);
                    p.BurstTime = 0;
                }
                else
                {
                    idle = proc.ArrivalTime - clk;
                    clk += idle;
                }
                finalprocs.Add(p);
            }
            return finalprocs;

        }
        public List<Process> RoundRobin(int quanta)
        {
            double clk = 0, idle;
            double rembt;
            var ordReadyQueue = ReadyQueue.OrderBy(proc => proc.ArrivalTime).ToList();
            List<Process> finalprocs = new List<Process>();
            bool allprocdone = false;
            while (!allprocdone)
            {

                foreach (var proc in ordReadyQueue)
                {
                    Process p = new Process(Convert.ToInt32(proc.ID), proc.BurstTime, proc.ArrivalTime, proc.Priority);
                    if (clk >= proc.ArrivalTime)
                    {
                        rembt = p.BurstTime;
                        if (rembt > 0)
                        {
                            //Need to execute the process
                            if (rembt > quanta)
                            {
                                clk += Convert.ToDouble(quanta);
                                p.FinalTime = clk;
                                rembt -= quanta;
                            }
                            else
                            {
                                clk += rembt;
                                p.WaitingTime = Convert.ToInt32(clk) - p.BurstTime;
                                rembt = 0;

                            }

                        }
                        
                        p.TurnAround = proc.calculate_turnaround(p.FinalTime, p.ArrivalTime);
                        p.WaitingTime = proc.calculate_waiting(p.TurnAround, p.BurstTime);
                        finalprocs.Add(p);
                    }
                    else
                    {
                        idle = proc.ArrivalTime - clk;
                        clk += idle;
                    }
                    allprocdone = true;

                }
                
            }
            return finalprocs;

        }
        public List<Process> HighestPriority()
        {
            var ordReadyQueue = ReadyQueue.OrderByDescending(proc => proc.Priority).ToList();
            double clk = 0;
            double idle;
            List<Process> finalprocs = new List<Process>();
            foreach (var proc in ordReadyQueue)
            {
                Process p = new Process(Convert.ToInt32(proc.ID), proc.BurstTime, proc.ArrivalTime, proc.Priority);
                if (clk >= proc.ArrivalTime)
                {
                    clk += proc.BurstTime;
                    p.FinalTime = Convert.ToInt32(clk);
                    p.TurnAround = p.calculate_turnaround(p.FinalTime, p.ArrivalTime);
                    p.WaitingTime = p.calculate_waiting(p.TurnAround, p.BurstTime);
                    proc.BurstTime = 0;

                }
                else
                {
                    idle = proc.ArrivalTime - clk;
                    clk += idle;
                }
                finalprocs.Add(p);

            }
            return finalprocs;
        }
        public void PreemptiveSRTF()
        {

        public class Times
        {

            static void CalculateWaitingTime(Process[] proc, int n, int[] WaitingTime)
            {
                int[] Burst = new int[n];

                for (int i = 0; i < n; i++)
                    Burst[i] = proc[i].BurstTime;

                int complete = 0, clk = 0, min = int.MaxValue;
                int shortest = 0, Finish;
                bool check = false;


                while (complete != n)
                {

                    for (int j = 0; j < n; j++)
                    {
                        if ((proc[j].ArrivalTime <= clk) && (Burst[j] < min) && Burst[j] > 0)
                        {
                            min = Burst[j];
                            shortest = j;
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        clk++;
                        continue;
                    }

                    Burst[shortest]--;

                    min = Burst[shortest];
                    if (min == 0)
                    {
                        min = int.MaxValue;
                    }

                    if (Burst[shortest] == 0)
                    {
                        complete++;
                        check = false;

                        Finish = clk + 1;

                        WaitingTime[shortest] = Finish - proc[shortest].BurstTime - proc[shortest].ArrivalTime;

                        if (WaitingTime[shortest] < 0)
                        {
                            WaitingTime[shortest] = 0;
                        }
                    }

                    clk++;
                }
            }
            static void CalculateTurnAroundTime(Process[] proc, int n, int[] WaitingTime, int[] TurnAroundTime)
            {

                for (int i = 0; i < n; i++)

                    TurnAroundTime[i] = proc[i].BurstTime + WaitingTime[i];
            }
            static void Calculate_AVG_Time(Process[] proc, int n)
            {
                int[] WaitingTime = new int[n]; int[] TurnAroundTime = new int[n];
                int TotalWait = 0, TotalTurnAround = 0;

                CalculateWaitingTime(proc, n, WaitingTime);

                CalculateTurnAroundTime(proc, n, WaitingTime, TurnAroundTime);

                for (int i = 0; i < n; i++)
                {
                    TotalWait = TotalWait + WaitingTime[i];
                    TotalTurnAround = TotalTurnAround + TurnAroundTime[i];
                    Console.WriteLine(" " + proc[i].pid + "\t\t" + proc[i].BurstTime + "\t\t" + WaitingTime[i] + "\t\t" + TurnAroundTime[i]);
                }
                float AVGWaitTime =  (float)TotalWait / n);
                float AVGTurnAround =  (float)TotalTurnAround / n);


            }
        }


    }


}
}
