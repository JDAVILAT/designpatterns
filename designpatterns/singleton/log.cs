using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class log
    {
        private readonly static log _instance = new log();

        private readonly string path = "log.txt";

        public static log Instance 
        { 
            get
            {
                return _instance;
            }
        }

        private log()
        {

        }

        public void save(string message)
        {
            File.AppendAllText(path, message + Environment.NewLine);
        }
    }
}
