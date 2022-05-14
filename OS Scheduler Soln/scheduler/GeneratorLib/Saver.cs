using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProcessGenerator
{
    public class Saver
    {
        public List<String> save(string[] s)
        {
            List<String> outputs = new List<string>();

            foreach (var str in s)
            {
                outputs.Add(str);
            }

            return outputs;

        }
    }
}
