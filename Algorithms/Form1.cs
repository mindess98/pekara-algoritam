using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Bubble Sort");
            comboBox1.Items.Add("Insertion Sort");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = textBox1.Text.Split(',');
            List<int> array = new List<int>();
            foreach(string t in s)
            {
                array.Add(int.Parse(t));
            }

            myAlgorithms.SortByID(comboBox1.SelectedIndex, array);

           for(int i = 0; i < array.Count; i++)
            {
                s[i] = array[i].ToString();
            }


           textBox1.Text = null;

           for (int i = 0; i < s.Length - 1; i++)
            {
                textBox1.Text += (s[i] + ","); 
            }
            textBox1.Text += s[s.Length - 1];
             
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
