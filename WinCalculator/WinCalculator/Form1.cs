using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalcLibaryAssign;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operators obj;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Add().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";

        }

        private void lblSub_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Subtract().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";

        }

        private void lblMul_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Multiply().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void lblDiv_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Divide().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void lblModulus_Click(object sender, EventArgs e)
        {
            obj = new Operators();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Modulus().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}
