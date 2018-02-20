using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class Searcher
    {
        private Form1 Form;
        public Searcher(Form1 Form)
        {
            this.Form = Form;
        }
        public int? BinarySearch(List<int> values, int query)
        {
            int max = values.Count - 1;
            int min = 0;
            int count = 0;
            

            while(min <= max)
            {
                Console.WriteLine("count: " + count);
                count++;
                int mid = (int)Math.Floor((min + max) / 2.0);
                if (query == values[mid])
                {
                    return mid;
                }
                else if (query > values[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            
            return null;
        }        
    }
}

