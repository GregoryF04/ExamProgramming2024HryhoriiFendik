using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string filePath = textBox1.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                    {
                        listBox1.Items.Add(line + Environment.NewLine);
                    }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string filePath = textBox1.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal TotalExpenses = 0;
                List<string> Categories = new List<string>();
                List<string> DateTimes = new List<string>();
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    string num = Convert.ToString(parts[1]);
                    string cont = num.Replace(".", ",");
                    TotalExpenses += decimal.Parse(cont);
                    Categories.Add(parts[2]);
                    DateTimes.Add(parts[0]);
                }
                listBox1.Items.Add($"Total expenses: {TotalExpenses}" +Environment.NewLine);
                listBox1.Items.Add($"Number of categories:  {Categories.Distinct().Count()}" + Environment.NewLine);
                listBox1.Items.Add($"Total expenses: {DateTimes.Distinct().Count()}" + Environment.NewLine);
            }
        }
    }
}
