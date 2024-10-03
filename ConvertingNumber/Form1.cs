using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        public string MultiplyByTwo (float input, int bitCount)
        {
            string result = "";
            while (bitCount < 23)  //start bitCount to 23
            {
                input *= 2;
                if (input >= 1)
                {
                    result += "1";
                    input -= 1;
                }
                else
                {
                    result += "0";
                }
                bitCount++;
            }
            return result;
        }
        public string DecimalToBinary(int input)          // Convert from Decimal to Binary
        {
            List<int> number = new List<int>();
            if (input < 0)                               // if input is a negative interger
            {
                input *= -1;                            
                while (input > 0)                       // Divide by two to get bit string and negate all the bits ( bit 0 -> 1, bit 1 -> 0 )
                {
                    int temp = input % 2;
                    if (temp == 1) number.Add(0);        
                    else number.Add(1);
                    input = input / 2;
                }
                while (number.Count < 32)                  
                {
                    number.Add(1);                       // assume that this is a 32-bit machine and append until get enough 32 bits
                }                                        // append 1 because this is a negative interger so the most significant bit must be 1
                number.Reverse();                         // reverse the bit string to get bit string from bottom 
                for(int i = number.Count - 1; i >= 0; i--)
                {
                    if (number[i] == 0) {                 // add 1 bit to the bit string because of the formula
                        number[i] = 1;
                        break; 
                    }
                    number[i] = 0;
                }
                binaryOutPut.Text = string.Join("", number);    // convert list to string and return result
            }                                                      
            else                                                 // if input is a positive interger
            {
                while (input > 0)
                {
                    number.Add(input % 2);                          // Divide by two to get bit string and negate all the bits ( bit 0 -> 1, bit 1 -> 0 )
                    input = input / 2;
                }
                number.Reverse();                                   //reverse and store result to return aimed to use for other caculation
                string result = string.Join("", number);
                number.Reverse();                                   //reverse again to append more bits
                while (number.Count < 32)
                {
                    number.Add(0);                         // assume that this is a 32-bit machine and append until get enough 32 bits
                }                                          // append 0 because this is a positive interger so the most significant bit must be 0
                number.Reverse();
                binaryOutPut.Text = string.Join("", number);       //display output
                return result;        
            }
            return "";
        }
        public int BinaryToDecimal(string binaryNumber)  // convert from binary to decimal
        {
            double result = 0;                           
            int exponent = binaryNumber.Length - 1;                  
            for(int i = 0; i < binaryNumber.Length; i++)       // caculate follow formula 
            {
                result += ((int)binaryNumber[i] - 48) * Math.Pow(2,exponent--);
            }
            return (int)result;
        }

        public void FloatingPointPresentation(float input) // convert from float number to binary using floating point repesentation
        {
            string result = "";
            if (input < 0)
            {
                result += "1";   //sign
                input *= -1;
            }

            else result += "0"; //sign 
            

            int intergerPart = Convert.ToInt32(input); // Interger Part
            input -= intergerPart;      // Decimal Part
            string temp = DecimalToBinary(intergerPart);
            string exponent = DecimalToBinary(127 + temp.Length - 1);
            temp = temp.Remove(0, 1);
            string mantissa = temp + MultiplyByTwo(input, temp.Length);
            result = result + exponent + mantissa;
            for (int i = result.Length - 1; i < 31; i++) // assume that this is a 32-bit machine and append
            {
                result += "0";
            }
            binaryOutPut.Text = result;
        }

        public void BinaryToHexaDecimal(string binaryNumber)
        {
            binaryNumber = binaryOutPut.Text;
            string result = "";
            while (binaryNumber.Length >= 4)
            {
                string fourBits = binaryNumber.Substring(0, 4);
                binaryNumber = binaryNumber.Substring(4);
                //MessageBox.Show(fourBits + "\n" + binaryNumber);
                if (fourBits == "0000")
                    result += '0';
                if (fourBits == "0001")
                    result += "1";
                if (fourBits == "0010")
                    result += "2";
                if (fourBits == "0011")
                    result += "3";
                if (fourBits == "0100")
                    result += "4";
                if (fourBits == "0101")
                    result += "5";
                if (fourBits == "0110")
                    result += "6";
                if (fourBits == "0111")
                    result += "7";
                if (fourBits == "1000")
                    result += "8";
                if (fourBits == "1001")
                    result += "9";
                if (fourBits == "1010")
                    result += "A";
                if (fourBits == "1011")
                    result += "B";
                if (fourBits == "1100")
                    result += "C";
                if (fourBits == "1101")
                    result += "D";
                if (fourBits == "1110")
                    result += "E";
                if (fourBits == "1111")
                    result += "F";
            }
            hexadecimalOutPut.Text = result;
        }
        #region Caculation Button
        private void CaculateButton_Click_Event_1(object sender, EventArgs e)
        {
            
            binaryOutPut.Text = "";
           
            int value; // input is an interger
            float Value; // input is a decimal
            if (!int.TryParse(inputData.Text, out value) && !float.TryParse(inputData.Text, out Value))
            {
                MessageBox.Show("Please enter number!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(inputData.Text, out value) && float.TryParse(inputData.Text, out Value)) {
                FloatingPointPresentation(Value);
            }

            else
            {
                DecimalToBinary(value);
            }
            BinaryToHexaDecimal(binaryOutPut.Text);
          

        }

        #endregion
        private void inputTextBoxClickEvent(object sender, EventArgs e)
        {
            inputData.Text = string.Empty;
            
        }
      
    }



}

