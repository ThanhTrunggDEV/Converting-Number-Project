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

       public void ConvertToBinary(int value)
        {
            List<int> number = new List<int>();
            if (value < 0)
            {
                value *= -1;
                while (value > 0)
                {
                    int temp = value % 2;
                    if (temp == 1) number.Add(0);
                    else number.Add(1);
                    value = value / 2;
                }
                while (number.Count < 32)
                {
                    number.Add(1);
                }
                number.Reverse();
                for(int i = number.Count - 1; i >= 0; i--)
                {
                    if (number[i] == 0) {
                        number[i] = 1;
                        break; 
                    }
                    number[i] = 0;
                }
                textBox2.Text = string.Join("", number);
            }
            else
            {
                while (value > 0)
                {
                    number.Add(value % 2);
                    value = value / 2;
                }
                number.Reverse();
                //string s = string.Join("", number);
                number.Reverse();
                while (number.Count < 32)
                {
                    number.Add(0);
                }
                number.Reverse();
                textBox2.Text = string.Join("", number);
                //return s;
            }
        }
       public int ConvertToDecimal(string binary)
        {
            double sum = 0;
            int exp = binary.Length - 1;
            for(int i = 0; i < binary.Length; i++)
            {
                sum += ((int)binary[i] - 48) * Math.Pow(2,exp--);
            }
            return (int)sum;
        }

       
        #region Caculation Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            
            int value;
            if (!int.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("Please enter number!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                ConvertToBinary(value);
            }
        }
        #endregion
    }



}

