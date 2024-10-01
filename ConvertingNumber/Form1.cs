using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertingNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(textBox1.Text);
                string s = "";
                while (value > 0)
                {
                    s += (value % 2).ToString();
                    value = value / 2;
                }
                 textBox1.Text = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    textBox2.Text += s[i];
                }
            }
            catch
            {
                MessageBox.Show("Error"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
