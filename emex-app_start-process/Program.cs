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
            System.Diagnostics.Process.Start(args[0]);
        }
    }
}
