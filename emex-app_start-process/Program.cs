using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emex_app_start_process
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) return;
            System.Diagnostics.Process.Start(args[0]);
        }
    }
}
