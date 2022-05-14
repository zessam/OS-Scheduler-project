using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Scheduler
{
    public class Parser
    {
        public List<Process> ParseFile(string pathin)
        {
            string filepath = pathin;
            string[] lines = File.ReadAllLines(filepath);
            int noofproc = Int32.Parse(lines[0]);
            lines = lines.Skip(1).ToArray();
            List<Process> listofproc = new List<Process>();
            foreach (var line in lines)
            {
                string[] processdata = line.Split(' ');
                Process p = new Process(Int32.Parse(processdata[0]), Double.Parse(processdata[2]), Double.Parse(processdata[1]), Double.Parse(processdata[3]));
                listofproc.Add(p);

            }
            Console.WriteLine("Done");
            return listofproc;
        }
    }
}
