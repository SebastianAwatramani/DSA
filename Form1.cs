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
            int[] valsBalls = new int[10] { 1, 2, 4, 8, 17, 26, 37, 48, 59,110};
            List<int> Balls = new List<int>(valsBalls);

            Searcher Searcher = new Searcher(this);

            int query = 48;
            int? index = Searcher.BinarySearch(Balls, query);

            Console.WriteLine("result: " + index);




        }
        public void AppendToOutput(String text)
        {
            output.Text += text;
        }

    }
}
