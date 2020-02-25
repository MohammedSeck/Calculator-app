using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_form.cs
{
    public partial class Form1 : Form
    {
        private object tab;

        public Form1()
        {
            InitializeComponent();
        }
        public double triangle()
        {
            double baseT = 0;
            double heightT = 0;
            return answer;
        }

        public double Circle()
        {
            double pi = 3.142;

            double radius = 0;
            double radius = 0;
        }
        public double Rectangle()
        {

            double lentgh = 0;
            double width = 0;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            private void btnTriangle Formula(object sender, EventArgs e)
        {
            // Textbox inputs
            string triBase = textBox7.Text;
            string triHeight = textBox6.Text;
            textBox5.Text = triangle().ToString("F") + "m2";
        }
    }
         }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
            Tab.selecTab("tb.Page2")
            Tab.selecTab("tb.Page3")
            Tab.selecTab("tb.Page4")
            Tab.selecTab("tb.Page5")
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            private void btnRectangle Formula(object sender, EventArgs e)
            {
                // Textbox inputs
                string triBase = textBox2.Text;
                string triHeight = textBox3.Text;
                textBox4.Text = triangle().ToString("F") + "m2";
            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            private void btnCircle Formula(object sender, EventArgs e)
            {
                // Textbox inputs
                string triBase = textBox10.Text;
                string triHeight = textBox9.Text;
                textBox8.Text = triangle().ToString("F") + "m2";
            }

        }


    }
}
