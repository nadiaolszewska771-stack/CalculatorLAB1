using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculation;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        calculate cal = new calculate();
        //Addition Button click event
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Add(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Subtraction button click event

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Sub(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
