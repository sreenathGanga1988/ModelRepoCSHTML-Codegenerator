using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavValueCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calculateSellableNav()
        {
            try
            {

                Decimal totalspendofday = 0;
                Decimal totalQty = 0;
                Decimal totalValue = 0;
                Decimal Purchaseprice = 0;

                try
                {
                    totalspendofday = Decimal.Parse(txt_Spendofday.Text);

                }
                catch (Exception)
                {


                }
                try
                {
                    totalQty = Decimal.Parse(txt_qty.Text);
                }
                catch (Exception)
                {


                }
                try
                {
                    Purchaseprice = Decimal.Parse(txt_buyPrice.Text);
                }
                catch (Exception)
                {


                }
                try
                {
                    totalValue = totalQty * Purchaseprice;
                }
                catch (Exception)
                {


                }
                try
                {
                    totalspendofday = Decimal.Parse(txt_Spendofday.Text);
                }
                catch (Exception)
                {


                }
                NavModel navModel = new NavModel();
                navModel.totalspendofday = totalspendofday;
                navModel.totalQty = totalQty;
                navModel.totalValue = totalValue;
                navModel.Purchaseprice = Purchaseprice;


                CalculateRepo calculateRepo = new CalculateRepo();
                navModel = calculateRepo.CalculateNav(navModel);
                txt_value.Text= navModel.totalValue.ToString();
                txt_actualsalevalue.Text = navModel.Totalvalueatpurchasre.ToString();
                txt_minimumSellingvalue.Text = navModel.MinimumSellablevalue.ToString();
            }
            catch (Exception)
            {

               
            }
        }

        private void txt_Spendofday_TextChanged(object sender, EventArgs e)
        {
            calculateSellableNav();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            calculateSellableNav();
        }

        private void txt_buyPrice_TextChanged(object sender, EventArgs e)
        {
            calculateSellableNav();
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            calculateSellableNav();
        }

        private void txt_actualsalevalue_TextChanged(object sender, EventArgs e)
        {
            calculateSellableNav();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateSellableNav();
        }
    }
}
