using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A.Source
{
    class Queue : IQueue
    {
        private List<int> _qu;
        private int _count;

        public List<int> Qu { get => _qu; set => _qu = value; }
        public int Count { get => _count; set => _count = value; }

        public Queue (int capacity)
        {
            this.Qu = new List<int>(capacity);
        }



        public bool CheckIfFull()
        {
            if(this.Qu.Count >= this.Qu.Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Dequeue()
        {
            int value = Qu.ElementAt(0);
            Qu.RemoveAt(0);
            Count--;
            Console.WriteLine(value.ToString());
            return value;

        }

        public void Enqueue(int value)
        {
            try
            {
                if (CheckIfFull() == false)
                {
                    Qu.Insert(Count, value);
                    Count++;
                }
                else
                {
                    throw new OverCapacityException();
                }
            }
            catch (OverCapacityException Exception)
            {
                 
            }
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
