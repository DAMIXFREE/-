using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            double X = 0;
            double.TryParse(textBox1.Text, out X);
            double Y = 0;
            double.TryParse(textBox1.Text, out Y);
            double resault = 1;
            if (radioButton3.Checked)
            {
                resault = 5 * X + 10 / Y;
            }
            else if (radioButton2.Checked)
            {
                resault = 4 * X + 15 / Y;
            }
            else if (radioButton1.Checked)
            {
                resault = 6 * X + 20 / Y;
            }
            else
                label3.Text = "вы не выбрали уравнение";

            
        } 
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
