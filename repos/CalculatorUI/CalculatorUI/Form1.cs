using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorData;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
          private void button1_Click_1(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.numberOne=textBox1.Text;
            calc.numberTwo =textBox2.Text;
            //calc.operationSysmbol = txtOperator.Text;
            double result= (Double.Parse(calc.numberOne) + Double.Parse(calc.numberTwo));
            textBox3.Text = result.ToString();
            // MessageBox.Show(result.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.numberOne = textBox1.Text;
            calc.numberTwo = textBox2.Text;
            //calc.operationSysmbol = txtOperator.Text;
            double result = (Double.Parse(calc.numberOne) * Double.Parse(calc.numberTwo));
            textBox3.Text = result.ToString();
            //MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.numberOne = textBox1.Text;
            calc.numberTwo = textBox2.Text;
            //calc.operationSysmbol = txtOperator.Text;
            double result = (Double.Parse(calc.numberOne) - Double.Parse(calc.numberTwo));
            textBox3.Text = result.ToString();
            //MessageBox.Show(result.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.numberOne = textBox1.Text;
            calc.numberTwo = textBox2.Text;
            //calc.operationSysmbol = txtOperator.Text;
            double result = (Double.Parse(calc.numberOne) / Double.Parse(calc.numberTwo));
            textBox3.Text = result.ToString();
           // MessageBox.Show(result.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.numberOne = textBox1.Text;
            calc.numberTwo = textBox2.Text;
            //calc.operationSysmbol = txtOperator.Text;
            double result = (Double.Parse(calc.numberOne) % Double.Parse(calc.numberTwo));
            textBox3.Text = result.ToString();
            ///MessageBox.Show(result.ToString());
        }

      
    }
}

