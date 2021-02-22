using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpectedPrice
{
    public partial class frmReturnOnInvestment : Form
    {
        public frmReturnOnInvestment()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal investment = Convert.ToDecimal(txtInvestment.Text);
            decimal ROI = Convert.ToDecimal(txtInterestROI.Text);

            decimal investmentGain = (ROI / 100) * investment + investment;
            decimal profit = investmentGain - investment;

            txtInvestment.Text = investment.ToString("c");
            txtInterestROI.Text = ROI.ToString() + "%";
            txtInvestmentGain.Text = investmentGain.ToString("c");
            txtProfit.Text = profit.ToString("c");

            txtInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
