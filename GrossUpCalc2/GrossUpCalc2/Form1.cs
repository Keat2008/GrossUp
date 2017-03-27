using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrossUpCalc2
{
    public partial class Form1 : Form
    {
        public decimal netamount;
        public decimal fedtax;
        public decimal ficasstax;
        public decimal ficamcaretax;
        public decimal statetax;
        public decimal localtax;
        public decimal k401pre;
        public decimal fedtaxamt;
        public decimal ficasstaxamt;
        public decimal ficamcaretaxamt;
        public decimal statetaxamt;
        public decimal localtaxamt;
        public decimal k401preamt;

        public decimal finalgross;
        //public decimal k401post;

        public Form1()
        {
            InitializeComponent();
            NetAMT.Text = "0";
            FedPer.Text = "0.0";
            FICASSPer.Text = "0.0";
            FICAMcarePer.Text = "0.0";
            StateTaxPer.Text = "0.0";
            LocalTaxPer.Text = "0.0";
            k401PrePer.Text = "0.0";
            //k401PostPer.Text = "0.0";

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            netamount = Convert.ToDecimal(NetAMT.Text);
            fedtax = Convert.ToDecimal(FedPer.Text);
            ficasstax = Convert.ToDecimal(FICASSPer.Text);
            ficamcaretax = Convert.ToDecimal(FICAMcarePer.Text);
            statetax = Convert.ToDecimal(StateTaxPer.Text);
            localtax = Convert.ToDecimal(LocalTaxPer.Text);
            k401pre = Convert.ToDecimal(k401PrePer.Text);
            //k401post = Convert.ToDecimal(k401PostPer.Text);

            decimal pertotal = fedtax + ficasstax + ficamcaretax + statetax + localtax + k401pre;

            pertotal = 100 - pertotal;
            pertotal = pertotal / 100;
            decimal grosstotal = netamount / pertotal;

            fedtaxamt = grosstotal * (fedtax / 100);
            ficasstaxamt = grosstotal * (ficasstax / 100);
            ficamcaretaxamt = grosstotal * (ficamcaretax / 100);
            statetaxamt = grosstotal * (statetax / 100);
            localtaxamt = grosstotal * (localtax / 100);
            k401preamt = grosstotal * (k401pre / 100);

            FedTaxAmt.Text = fedtaxamt.ToString("0.##");
            FICASSAmt.Text = ficasstaxamt.ToString("0.##");
            FICAMcareAmt.Text = ficamcaretaxamt.ToString("0.##");
            StateTaxAmt.Text = statetaxamt.ToString("0.##");
            LocalTaxAmt.Text = localtaxamt.ToString("0.##");
            k401PreAmt.Text = k401preamt.ToString("0.##");

            finalgross = Math.Round(fedtaxamt,2) + Math.Round(ficasstaxamt,2) + Math.Round(ficamcaretaxamt,2) + Math.Round(statetaxamt,2) + Math.Round(localtaxamt,2) 
                + Math.Round(k401preamt,2) + netamount;


            GrossAmt.Text = finalgross.ToString("0.##");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clr_Click(object sender, EventArgs e)
        {
            NetAMT.Text = "0";
            FedPer.Text = "0.0";
            FICASSPer.Text = "0.0";
            FICAMcarePer.Text = "0.0";
            StateTaxPer.Text = "0.0";
            LocalTaxPer.Text = "0.0";
            k401PrePer.Text = "0.0";
            //k401PostPer.Text = "0.0";
            GrossAmt.Text = "";
            FedTaxAmt.Text = "";
            FICASSAmt.Text = "";
            FICAMcareAmt.Text = "";
            StateTaxAmt.Text = "";
            LocalTaxAmt.Text = "";
            k401PreAmt.Text = "";
            //k401PostAmt.Text = "";
            GrossAmt.Text = "";
        }
    }
}
