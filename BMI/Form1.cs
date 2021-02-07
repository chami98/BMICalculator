using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMICALCULATOR : Form
    {
        public BMICALCULATOR()
        {
            InitializeComponent();
        }

        private void showBMI_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(inputWeight.Text);
            double height = double.Parse(inputHeight.Text);

            Calculation obj = new Calculation();
            double bmi = obj.calculateBmi(weight, height);

            String bmiState = obj.bmiState(bmi);

            lblBmiValue.Text = bmi.ToString();
            lblCondition.Text = bmiState;

            string bmiCondition = obj.bmiCondition(bmiState);
            MessageBox.Show(bmiCondition,"BMI Condition",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
