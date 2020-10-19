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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void HomeLogin_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            String textbox = this.PhoneNumber.Text;
            if (!textbox.Equals(""))
            {
                this.Hide();
                form3.Show();
            }
            else { this.ErrorMessage.Text = "Please enter a phone number."; }

           
        }


    }
}
