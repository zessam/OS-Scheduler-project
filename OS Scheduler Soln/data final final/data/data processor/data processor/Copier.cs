using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_processor
{
    public class Copier
    {
        private string copytopath;
        private string frompath;
        public Copier(string fpath , string cpath)
        {
            copytopath = cpath;
            frompath = fpath;
        }
        public void copy()
        {
            File.Copy(frompath, copytopath);
        }
    }
}
