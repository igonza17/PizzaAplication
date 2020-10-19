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
    public partial class Form5 : Form
    {
        private double totalOrderCost = 0.0;
        private int NumberofPizzas = 0;
        public Form5()
        {
            InitializeComponent();
        }



        private void DrinksButton_Click(object sender, EventArgs e)
        {
            String CurrentSelection = this.DrinkSize.SelectedItem.ToString();
            String drinkSize = "";
            double drinkcost = 0.0;
            if (CurrentSelection.Contains("Small"))
            {
                this.totalOrderCost += 1.5;
                drinkcost = 1.5;
                drinkSize = "Small";
            }
            if (CurrentSelection.Contains("Medium"))
            {
                this.totalOrderCost += 2.5;
                drinkcost = 2.5;
                drinkSize = "Medium";

            }
            if (CurrentSelection.Contains("Large"))
            {
                this.totalOrderCost += 3.5;
                drinkcost = 3.5;
                drinkSize = "Large";

            }


            this.CurrentOrder.Text = this.CurrentOrder.Text + "\n" + drinkSize + "--------------$" + drinkcost + "0";
            this.CurrentTotalCost.Text = "Total: --------------$" + totalOrderCost + "0";
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            NumberofPizzas += 1;
            double currentCostOfPizza = 0;
            String CurrentSize = this.size.SelectedItem.ToString();
            String CurrentCrust = this.crust.SelectedItem.ToString();
            //String CurrentTopping1 = this.Topping1.SelectedItem.ToString();
            String CurrentTopping2 = this.Topping2.SelectedItem.ToString();
            String CurrentTopping3 = this.Topping3.SelectedItem.ToString();
            String CurrentTopping4 = this.Topping4.SelectedItem.ToString();

            // For adding cost of size of pizza
            if (CurrentSize.Contains("Small"))
            {
                this.totalOrderCost += 10.5;
                currentCostOfPizza += 10.5;
            }
            if (CurrentSize.Contains("Medium"))
            {
                this.totalOrderCost += 15.5;
                currentCostOfPizza += 15.5;
            }
            if (CurrentSize.Contains("Large"))
            {
                this.totalOrderCost += 20.5;
                currentCostOfPizza += 20.5;
            }
            if (CurrentSize.Contains("Huge"))
            {
                this.totalOrderCost += 25.5;
                currentCostOfPizza += 25.5;
            }


            //For adding cost of crust (Only for deep dish)
            if (CurrentCrust.Contains("Deep"))
            {
                this.totalOrderCost += 2.0;
                currentCostOfPizza += 2.0;
            }

            //For adding cost of second topping
            if (CurrentTopping2.Contains("Pepperoni") || CurrentTopping2.Contains("Olives") ||
                CurrentTopping2.Contains("Onions") || CurrentTopping2.Contains("Sausage"))
            {
                this.totalOrderCost += 0.2;
                currentCostOfPizza += 0.2;
            }
            if (CurrentTopping2.Contains("Bacon") || CurrentTopping2.Contains("Pineapple") ||
                CurrentTopping2.Contains("Basil") || CurrentTopping2.Contains("Jalapenos"))
            {
                this.totalOrderCost += 0.3;
                currentCostOfPizza += 0.3;
            }

            //For adding cost of third topping
            if (CurrentTopping3.Contains("Pepperoni") || CurrentTopping3.Contains("Olives") ||
                    CurrentTopping3.Contains("Onions") || CurrentTopping3.Contains("Sausage"))
            {
                this.totalOrderCost += 0.2;
                currentCostOfPizza += 0.2;
            }
            if (CurrentTopping3.Contains("Bacon") || CurrentTopping3.Contains("Pineapple") ||
                CurrentTopping3.Contains("Basil") || CurrentTopping3.Contains("Jalapenos"))
            {
                this.totalOrderCost += 0.3;
                currentCostOfPizza += 0.3;
            }

            //For adding cost of fourth topping
            if (CurrentTopping4.Contains("Pepperoni") || CurrentTopping4.Contains("Olives") ||
                    CurrentTopping4.Contains("Onions") || CurrentTopping4.Contains("Sausage"))
            {
                this.totalOrderCost += 0.2;
                currentCostOfPizza += 0.2;
            }
            if (CurrentTopping4.Contains("Bacon") || CurrentTopping4.Contains("Pineapple") ||
                CurrentTopping4.Contains("Basil") || CurrentTopping4.Contains("Jalapenos"))
            {
                this.totalOrderCost += 0.3;
                currentCostOfPizza += 0.3;
            }

            //Format view for customer
            this.CurrentOrder.Text = this.CurrentOrder.Text + "\nPizza " + NumberofPizzas + 
                "-----------$" + currentCostOfPizza + "0";
            this.CurrentTotalCost.Text = "Total: --------------$" + totalOrderCost + "0";
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this.totalOrderCost);
            this.Hide();
            form6.Show();
        }
    }
}
