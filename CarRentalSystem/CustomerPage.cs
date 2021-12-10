using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class CustomerPage : Form
    {
        CarRentalEntities db;
        public CustomerPage()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                f_name = textBox2.Text,
                l_name = textBox3.Text,
                mob = textBox4.Text,
                licence = textBox5.Text,
                dob = textBox6.Text,
                issue_date = textBox7.Text,
                addr = textBox8.Text
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer added :" + textBox2.Text);
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
