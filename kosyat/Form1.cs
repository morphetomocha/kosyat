using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosyat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(vvod1.Text);
            int m = Convert.ToInt32(vvod2.Text);

            vivod1.Clear();
            vivod2.Clear();

            int[,] massiv = new int[m, n]; 

            Random rand = new Random();

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    massiv[i,j] = rand.Next(100);
                    vivod1.Text += massiv[i, j] + " ";
                    massiv[i, j] = 1 - massiv[i, j];
                    vivod2.Text += massiv[i, j] + " ";
                }
                vivod1.Text += "\n";
                vivod2.Text += "\n";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(vvod1.Text);
            int m = Convert.ToInt32(vvod2.Text);

            vivod1.Clear();
            vivod2.Clear();

            int[,] massiv = new int[m, n];

            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    massiv[i, j] = rand.Next(100);
                    vivod1.Text += massiv[i, j] + " ";
                }
                vivod1.Text += "\n";
            }

            for(int i = 0; i < n; i += 2)
            {
                var sum = 0;
                for(int j = 0; j < m; j++)
                {
                    sum += massiv[j, i];
                    vivod2.Text += massiv[j, i] + "+";
                }
                vivod2.Text += "="+sum + "\n";
            }

        }
    }
}
