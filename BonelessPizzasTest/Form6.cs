using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonelessPizzasTest
{
    public partial class Form6 : Form
    {
        private double totalCost;
        public Form6(double totalCost)
        {
            InitializeComponent();


            double taxes = Math.Round(totalCost * 0.09);
            double FullTotal = totalCost + taxes;
            this.totalCost = totalCost;
            this.Subtotal.Text = "Subtotal:................." + totalCost;
            this.tax.Text = "Tax:........................" + taxes;
            this.Total.Text = "Total:......................" + FullTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
