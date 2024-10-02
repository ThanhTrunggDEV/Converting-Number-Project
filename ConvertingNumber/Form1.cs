using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ConvertingNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string multiply_by_2 (float val)
        {
            string s = "";
            int cnt = 0;
            while (cnt <= 8)
            {
                val *= 2;
                if (val >= 1)
                {
                    s += "1";
                    val -= 1;
                }
                else
                {
                    s += "0";
                }
                cnt++;
            }
            return s;
        }
        public string ConvertToBinary(int value)
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
                string s = string.Join("", number);
                number.Reverse();
                while (number.Count < 32)
                {
                    number.Add(0);
                }
                number.Reverse();
                textBox2.Text = string.Join("", number);
                return s;
            }
            return "";
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

        public void ConvertToBinaryforDecimal(float Value)
        {
            string s = "";
            if (Value < 0)
            {
                s += "1";
                Value *= -1;
            }

            else s += "0";
            

            int intner = Convert.ToInt32(Value);
            Value -= intner;
            string s0 = ConvertToBinary(intner);
            string s1 = ConvertToBinary(127 + s0.Length - 1);
            s0 = s0.Remove(0, 1);
            string s2 = s0 + multiply_by_2(Value);
            s = s + s1 + s2;
            for (int i = s.Length - 1; i < 32; i++)
            {
                s += "0";
            }
            textBox2.Text = s;
        }

       
        #region Caculation Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int value; // value is a interger
            float Value; // Value is a decimal
            if (!int.TryParse(textBox1.Text, out value) && !float.TryParse(textBox1.Text, out Value))
            {
                MessageBox.Show("Please enter number!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out value) && float.TryParse(textBox1.Text, out Value )) {
                ConvertToBinaryforDecimal(Value);
            }

            else
            {
                ConvertToBinary(value);
            }
        }
        #endregion
    }



}

