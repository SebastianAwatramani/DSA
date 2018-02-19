using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{

    interface IStack
    {
        int? Pop();
        void Push(int value);
        int? Peek();
    }

    class ListStack : IStack
    {
        private LinkedList List;


        public ListStack()
        {
            this.List = new LinkedList();
        }

        public int? Pop()
        {
            int value = this.List.Head.Data;
            this.List.DeleteFromHead();
            return value;
        }

        public void Push(int value)
        {
            this.List.InsertAtHead(value);
        }
        public int? Peek()
        {
            return this.List.Head.Data;
        }
    }
    class ArrayStack : IStack
    {
        private List<int?> ArrayList;
        private int top;

        public ArrayStack()
        {
            this.ArrayList = new List<int?>();
            this.top = -1;
        }
        public int? Pop()
        {
            try 
            {
                int? poppedData = this.ArrayList[top];
                this.ArrayList.RemoveAt(this.top);
                this.top--;
                return poppedData;
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public void Push(int value)
        {
            this.ArrayList.Add(value);            
            this.top++;

        }
        public int? Peek()
        {
            if (this.top > -1)
            {
                return this.ArrayList[top];
            }
            else
            {
                return null;
            }
        }


    }
}