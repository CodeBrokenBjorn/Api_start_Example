using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathsExampleLibary;

namespace Api_Example
{
    public partial class Form1 : Form
    {
        private MathsExampleLibary.main myObject; //Create an object variable for the main class
        public Form1()
        {
            InitializeComponent();
            myObject = new MathsExampleLibary.main(); //Initial the libary

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = myObject.Add(double.Parse(textBox2.Text),
               double.Parse(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = myObject.Subtract(double.Parse(textBox2.Text),
                double.Parse(textBox1.Text)).ToString();
        }
    }
}
