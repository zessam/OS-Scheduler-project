
using Scheduler;
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
        public List<Process> PreemptiveSRTF()
        {
            double clk = 0, idle;
            double mint;
            var ordReadyQueue = ReadyQueue.OrderBy(proc => proc.ArrivalTime).ToList();
            List<Process> finalprocs = new List<Process>();
            mint = ordReadyQueue[0].BurstTime;
            List<Process> Remprocs = new List<Process>();
            foreach(var proc in ordReadyQueue)
            {
                Remprocs.Add(proc);
            }
            foreach(var proc in ordReadyQueue)
            {
                Process p = new Process(Convert.ToInt32(proc.ID), proc.BurstTime, proc.ArrivalTime, proc.Priority);
                if (clk >= proc.ArrivalTime)
                {
                   if(proc.BurstTime != mint)
                    {
                        idle = proc.ArrivalTime - clk;
                        clk += idle;
                    }
                    else
                    {
                        clk += proc.BurstTime;
                        p.FinalTime = clk;
                        p.TurnAround = p.calculate_turnaround(p.FinalTime, p.ArrivalTime);
                        p.WaitingTime = p.calculate_waiting(p.TurnAround, p.BurstTime);
                        Remprocs.Remove(proc);
                        foreach(var proc2 in Remprocs)
                        {
                            if (mint > proc2.BurstTime)
                            {
                                mint = proc2.BurstTime;
                            }
                        }
                    }
                    
                }
                finalprocs.Add(p);
            }
            return finalprocs;
        }
    } 
}
