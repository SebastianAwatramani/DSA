using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A.Source
{
    class OverCapacityException : Exception
    {
        public OverCapacityException()
        {
            Console.WriteLine("Over cap");
        }
    }
}
