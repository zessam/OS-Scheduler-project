using System;
using System.Collections.Generic;
using System.Text;
using Scheduler;

namespace ProcessGenerator
{
    public class CProcessGenerator
    {
        public List<String> GenerateProcesses(string pathin)
        {

            var data = new Loader().load(pathin);
            var distribution = new Distribution();

            LinkedList<Process> processes = new LinkedList<Process>();
            for (int i = 0; i < data.Item1; i++)
            {
                processes.AddLast(new Process(i, distribution.normal(data.Item2, data.Item3), distribution.normal(data.Item4, data.Item5), (int)distribution.poisson(data.Item6)));
            }
            string[] _out = new string[data.Item1];

            foreach (var p in processes)
            {
                if (p.ID == 0)
                {
                    _out[0] = ($"{data.Item1 + Environment.NewLine}");   // Environment.Newline acts as an endl in c++

                }
                _out[Convert.ToInt32(p.ID)] += ($" {p.ID+1}  {p.ArrivalTime} {p.BurstTime} {p.Priority}");  // (Error out of bounds) P.ID +1 to match the output example provided

            }
            List<String> outputs = new Saver().save(_out);
            // Console.WriteLine (distribution);
            //Console.WriteLine(data.Item1);  test for each item being processed
            return outputs;

        }


    }
}
