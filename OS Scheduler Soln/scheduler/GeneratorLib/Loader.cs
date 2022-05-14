using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProcessGenerator
{
    public class Loader
    {
        public Tuple<int, double, double, double, double, double> load(string pathin)
        {
            string path = pathin;
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
            string[] output = path_out.Split(' ');   //turns text file into an array

             return new Tuple<int, double, double, double, double, double>(int.Parse(output[0]), double.Parse(output[1]), double.Parse(output[2]), double.Parse(output[3]), double.Parse(output[4]), double.Parse(output[5]));
        }
    }
}
