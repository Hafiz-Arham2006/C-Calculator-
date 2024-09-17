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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txt1.Text!="" && txt2.Text!="")
            {
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int result = num1 + num2;
            lbl_result.Text = "The Addition Result is : " + Convert.ToString(result);
            }
            else
            {
          MessageBox.Show("Please fill fields Properly!","Error" , MessageBoxButtons.OK,MessageBoxIcon.Error);

            }



        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                int num1 = Convert.ToInt32(txt1.Text);
                int num2 = Convert.ToInt32(txt2.Text);
                int result = num1 - num2;
                lbl_result.Text = "The Subtraction Result is : " + Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Please fill fields Properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                int num1 = Convert.ToInt32(txt1.Text);
                int num2 = Convert.ToInt32(txt2.Text);
                int result = num1 * num2;
                lbl_result.Text = "The Multiplication Result is : " + Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Please fill fields Properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                double num1 = Convert.ToDouble(txt1.Text);
                double num2 = Convert.ToDouble(txt2.Text);
                double result = num1 / num2;
                lbl_result.Text = "The Division Result is : " + Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Please fill fields Properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
