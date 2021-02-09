using System;
using System.Windows.Forms;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //      private void textBox1_TextChanged(object sender, EventArgs e)
        //      {
        //
        //      }

        string btn_oper;
        bool firstReady;
        float a=0, b=0, z=0;

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DisplayText("8");
        }


        public string DisplayText(string num)
        {
            
            if (display.Text == "0.00")
            {
                display.Text = "";
            }
            if (firstReady==true)
            {
                display.Text = "";
                firstReady = false;
            }
             display.Text += num;
            return num;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DisplayText("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DisplayText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DisplayText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DisplayText("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DisplayText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DisplayText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DisplayText("3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DisplayText("0");
        }

        private void btn_divid_Click(object sender, EventArgs e)
        {
            btn_oper = "/";
            MatAction();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            btn_oper = "*";
            MatAction();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            btn_oper = "-";
            MatAction();

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            btn_oper = "+";
            MatAction();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {


                label4.Text = "=";
                label4.Visible = true;
                b = float.Parse(display.Text,
                System.Globalization.CultureInfo.InvariantCulture);
                label2.Text = "второе число: " + Convert.ToString(b);
                label2.Visible = true;
                string c = btn_oper;
                MatOperation(c);
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            z = 0;
            display.Text = "0.00";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            DisplayText(".");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (z == 0 && display.Text != "")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            display.Text = "0.00";
        }

        public void MatOperation(string c)
        {
            switch (c)

            {
                case "+":
                    z = a + b;
                    MatFunction(z);
                    break;

                case "-":
                    z = a - b;
                    MatFunction(z);
                    break;

                case "/":

                    z = a / b;
                    MatFunction(z);
                    break;

                case "*":

                    z = a * b;
                    MatFunction(z);
                    break;

                default:

                    display.Text = "Ошибка однако!!!";

                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            float i = float.Parse(display.Text,
             System.Globalization.CultureInfo.InvariantCulture);
            i *= -1;
            display.Text = Convert.ToString(i);
        }

        private void MatFunction(float z)
        {
            display.Text = Convert.ToString(z);
            label5.Text = Convert.ToString(z);
            label5.Visible = true;
        }

        private void MatAction()
        {
            firstReady = true;
            a = float.Parse(display.Text,
             System.Globalization.CultureInfo.InvariantCulture);
            label1.Text = "первое число: " + Convert.ToString(a);
            label1.Visible = true;
            //btn_oper = "+";
            label3.Text = btn_oper;
            label3.Visible = true;


        }
    }
}
