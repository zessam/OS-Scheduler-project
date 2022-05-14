using System;
using System.Text;
using System.IO;
using System.Numerics;
using System.Collections.Generic;


namespace data_processor
{
    class saver
    {

        public void save(string[] s)
        {
            string pathout = @"output.txt";
            
            
                using (StreamWriter writer = File.CreateText(pathout))
                {
                foreach (string w in s)
                {
                   writer.WriteLine(w); 
                }
                    
                }
            
        }
    }
class loader
    {
        public Tuple<int, double, double, double, double, double> load(string fpath)
        {
            string path = fpath;
            string path_out = "";
            //FileStream data = new FileStream("C:Users\\user\\Desktop\\file path\\test.txt", FileMode.Open, FileAccess.Read);

            //could be used if File.OpenText isnt used

            StreamReader reader = File.OpenText(path);

            //reader.BaseStream.Seek(0, SeekOrigin.Begin);

            //could be used if File.OpenText isnt used

            string stuff;

            //Console.WriteLine(stuff);

            while ((stuff = reader.ReadLine()) != null)
            {

                path_out += stuff + " ";
            }
            Console.WriteLine(path_out);
            string[] output = path_out.Split(" ");   //turns text file into an array

            return new Tuple<int, double, double, double, double, double>(int.Parse(output[0]), double.Parse(output[1]), double.Parse(output[2]), double.Parse(output[3]), double.Parse(output[4]), double.Parse(output[5]));
        }
    }
   
   
        
    
    class distribution
    {
        public double normal(double mean, double stdDev)
        {
            
            Random rand = new Random(); //reuse this if you are generating many
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
            return randNormal; 

        }
        public double poisson(double lambda)
        {
            return normal(lambda, Math.Sqrt(lambda));
        }
     
    }
    class process
    {
        
        public int id;
        public double burst_time;
        public double arrival_time;
        public int priority; 
    
        public process(int id, double burst_time, double arrival_time, int priority)
        {
            this.id = id;
            this.burst_time = burst_time;
            this.arrival_time = arrival_time;
            this.priority = priority;
        }

    }
    class Program
    {
       


        //listed string
        /* string[] loader()
    {
        string path = @"C:\Users\user\Desktop\file path\test.txt";
        string path_out = "";
        //FileStream data = new FileStream("C:Users\\user\\Desktop\\file path\\test.txt", FileMode.Open, FileAccess.Read);

        //could be used if File.OpenText isnt used

        StreamReader reader = File.OpenText(path);

        //reader.BaseStream.Seek(0, SeekOrigin.Begin);

        //could be used if File.OpenText isnt used

        string stuff;
        //Console.WriteLine(stuff);
        while ((stuff = reader.ReadLine()) != null)
        {

            path_out += stuff + " ";
        }
        Console.WriteLine(path_out);
        string[] output = path_out.Split(" ");   //turns text file into an array
        return output;



    }
   */
        static void  Main(string[] args)
        {
            Console.WriteLine("Enter the path of the test file: ");
            string fpath = Console.ReadLine();
            var data = new loader().load(fpath);
            var distribution = new distribution();
            
            LinkedList<process> processes = new LinkedList<process>();
            for (int i = 0; i<data.Item1; i++)
            {
                processes.AddLast(new process(i, distribution.normal(data.Item2, data.Item3), distribution.normal(data.Item4, data.Item5), (int)distribution.poisson(data.Item6)));
            }
            string[] _out = new string [data.Item1];
           
            foreach (process p in processes)
            {
                if (p.id == 0 )
                    {
                    _out[0] = ($"{data.Item1 + Environment.NewLine}");   // Environment.Newline acts as an endl in c++

                }
                _out[p.id] +=($"{p.id + 1} {p.arrival_time} {p.burst_time} {p.priority}");  // P.ID +1 to match the output example provided

            }
            new saver().save(_out);
            Console.WriteLine("Enter the destination: ");
            string cpath = Console.ReadLine();
            Copier cp = new Copier("output.txt" , cpath+"/output.txt");
            cp.copy();
            Console.WriteLine("Done");
            // Console.WriteLine (distribution);
            //Console.WriteLine(data.Item1);  test for each item being processed

            
            
        }

    }
}
