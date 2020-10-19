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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RegistrationRegister_Click(object sender, EventArgs e)
        {
            String Textbox1 = this.textBox1.Text;
            String Textbox2 = this.textBox2.Text;
            String Textbox3 = this.textBox3.Text;
            String Textbox4 = this.textBox4.Text;
            String Textbox5 = this.textBox5.Text;
            String Textbox6 = this.textBox6.Text;
            String Textbox7 = this.textBox7.Text;
            Form3 form3 = new Form3();
            if(!(Textbox1.Equals("") || Textbox2.Equals("") || Textbox3.Equals("") 
                || Textbox4.Equals("") || Textbox5.Equals("") || Textbox6.Equals("") || Textbox7.Equals(""))) {
                this.Hide();
                form3.Show();
            }
            else
            {
                this.ErrorMessage.Text = "Please enter all information.";
            }
        }
    }
}
