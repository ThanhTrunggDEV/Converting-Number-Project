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
            
            
                
                while (value > 0)
                {
                    number.Add(value % 2);
                    
                    value = value / 2;
                    
                }

                while(number.Count < 32)
                {
                    number.Add(0);
                }
                number.Reverse();
            textBox2.Text = string.Join("", number);

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
    }

        
    
}

