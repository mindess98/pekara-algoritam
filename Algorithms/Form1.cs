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
            label1.AutoSize = true;
            label2.AutoSize = true;
            comboBox1.Items.Add("Bubble Sort");
            comboBox1.Items.Add("Insertion Sort");
            comboBox1.Items.Add("Quick Sort");
            comboBox1.Items.Add("Merge Sort");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("isPrime");
            comboBox2.Items.Add("isHappy");
            comboBox2.Items.Add("isLucky");
            comboBox2.SelectedIndex = 0;
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
                 label1.Text += (s[i] + ","); 
             }
             label1.Text += s[s.Length - 1];
             

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            label2.Text = myAlgorithms.AlgByID(comboBox2.SelectedIndex, n).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] s = textBox3.Text.Split(',');
            List<int> array = new List<int>();
            foreach (string t in s)
            {
                array.Add(int.Parse(t));
            }

            int value = int.Parse(textBox4.Text);

            myAlgorithms.insert(array, value);

            textBox3.Text = null;

            for (int i = 0; i < array.Count - 1; i++)
            {
                textBox3.Text += array[i].ToString() + ",";
            }
            textBox3.Text += array[array.Count - 1].ToString();
        }
    }
}
