using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Frm_Main : Form
    {
        private string num1 = null, num2 = null,num3=null, flag = null;

        public string Js(String fh)
        {
            switch (fh)
            {
                case "+":
                    num3 = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                   
                    break;
                case "-":
                    num3 = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    
                    break;
                case "*":
                    num3 = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                    
                    break;
                case "/":
                    num3 = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                   
                    break;
                case "%":
                    num3 = Convert.ToString(Convert.ToDouble(num1) % Convert.ToDouble(num2));
                    
                    break;
                default:
                    break;
            }
            textBox1.Text = num3;
            //label1.Text = num3;
            flag = null;
            num1 = num3;
            num2 = null;
            return num3;
            
        }

        public Frm_Main()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            textBox1.Text += "1";
            if (flag == null)
            {
                num1 = num1 + "1";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "1";
                textBox1.Text = num2;
            }
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text+= "2";
            textBox1.Text+= "2";
            if (flag == null)
            {
                num1 = num1 + "2";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "2";
                textBox1.Text = num2;
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            textBox1.Text += "3";
            if (flag == null)
            {
                num1 = num1 + "3";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "3";
                textBox1.Text = num2;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            textBox1.Text += "4";
            if (flag == null)
            {
                num1 = num1 + "4";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "4";
                textBox1.Text = num2;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            textBox1.Text += "5";
            if (flag == null)
            {
                num1 = num1 + "5";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "5";
                textBox1.Text = num2;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            textBox1.Text += "6";
            if (flag == null)
            {
                num1 = num1 + "6";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "6";
                textBox1.Text = num2;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            textBox1.Text += "7";
            if (flag == null)
            {
                num1 = num1 + "7";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "7";
                textBox1.Text = num2;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            textBox1.Text += "8";
            if (flag == null)
            {
                num1 = num1 + "8";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "8";
                textBox1.Text = num2;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            textBox1.Text += "9";
            if (flag == null)
            {
                num1 = num1 + "9";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "9";
                textBox1.Text = num2;
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            textBox1.Text += "0";
            if (flag == null)
            {
                num1 = num1 + "0";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + "0";
                textBox1.Text = num2;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
            textBox1.Text += ".";
            if (flag == null)
            {
                num1 = num1 + ".";
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2 + ".";
                textBox1.Text = num2;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            label1.Text= "";
            textBox1.Text = "";
            num1 = null;
            num2 = null;
            num3 = null;
            flag = null;


        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (flag != null)
                Js(flag);
            label1.Text += "*";
            textBox1.Text += "*";
            flag = "*";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (flag != null)
                Js(flag);
            label1.Text += "/";
            textBox1.Text += "/";
            flag = "/";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (flag != null)
                Js(flag);
            label1.Text += "%";
            textBox1.Text += "%";
            flag = "%";
        }

        

        private void Button12_Click(object sender, EventArgs e)
        {
            if (flag != null)
                Js(flag);
            label1.Text += "+";
            textBox1.Text += "+";
            flag = "+";
        }

       
        private void Button13_Click(object sender, EventArgs e)
        {
            if (flag != null)
                Js(flag);
            label1.Text += "-";
            textBox1.Text += "-";
            flag = "-";

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            label1.Text += "=";
            textBox1.Text += "=";
            Js(flag);
            label1.Text += num3;
        }
        


    }
}
