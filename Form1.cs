using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_And_A
{
    public partial class Form1 : Form
    {
    //Bubble sort
    
        public Form1()
        {
            InitializeComponent();

            //int[] valsBalls = new int[6] { 10, 2, 8, 6, 7, 3 };
            //int[] valsBalls = new int[10] { 1, 2, 4, 8, 17, 26, 37, 48, 59,110};
            //List<int> Balls = new List<int>(valsBalls);

            //Searcher Searcher = new Searcher(this);

            //int query = 48;
            //int? index = Searcher.BinarySearch(Balls, query);

            //Console.WriteLine("result: " + index);

            Source.Queue queue = new Source.Queue(10);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(11);
            for (int i = queue.Count; i > 0; i--)
            {
              
                queue.Dequeue();
            }




        }
        public void AppendToOutput(String text)
        {
            output.Text += text;
        }

    }
}
