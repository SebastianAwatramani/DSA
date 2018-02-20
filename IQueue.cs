using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A.Source
{
    interface IQueue
    {
        void Enqueue(int value);
        int Dequeue();
        int Peek();
        bool CheckIfFull();
    }
}
