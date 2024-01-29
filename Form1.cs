using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hill_SalesTaxCalc_Project
{
    public partial class mainFrm : Form
    {
        double BaseVehiclePrice = 0.00D;
        double WarrantyPrice = 0D;
        double WA_TaxRate = 1.087D;
        double OR_TaxRate = 1.000D;
        double taxRate = 1.00D;
        double totalVechiclePrice = 0.00D;

        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "";
            txtBasePrice.Focus();
            cboState.SelectedIndex = 0;
            cboWarranty.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            totalVechiclePrice =  WarrantyPrice += BaseVehiclePrice *= taxRate;
            lblTotalPrice.Text = "Total Vehical Cost Is: $" + totalVechiclePrice.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "";
            txtBasePrice.Clear();
            txtBasePrice.Focus();
            cboState.SelectedIndex = 0;
            cboWarranty.SelectedIndex = 0;
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboState.SelectedIndex == 0)
            {
                taxRate = WA_TaxRate;
            }
            if (cboState.SelectedIndex == 1) 
            { 
                taxRate = OR_TaxRate; 
            }
        }

        private void cboWarranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWarranty.SelectedIndex == 0)
            {
                WarrantyPrice = 0;
            }
            else if (cboWarranty.SelectedIndex == 1)
            {
                WarrantyPrice = 1000;
            }
            if (cboWarranty.SelectedIndex == 2)
            {
                WarrantyPrice = 2000;
            }
            if (cboWarranty.SelectedIndex == 3)
            {
                WarrantyPrice = 3000;
            }
        }

        private void txtBasePrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBasePrice.Text))
            {
            BaseVehiclePrice = double.Parse(txtBasePrice.Text);
            }

        }
    }
}
