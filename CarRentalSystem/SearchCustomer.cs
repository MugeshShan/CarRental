using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class SearchCustomer : Form
    {
        CarRentalEntities db;
        public SearchCustomer()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                var customers = db.Customers.ToList();
                var resultCustomers = new List<CustomerPageModel>();

                customers.ForEach(x =>
                {
                    if (x.f_name.Equals(textBox1.Text))
                    {
                        resultCustomers.Add(new CustomerPageModel {
                            First_name = x.f_name,
                            Last_name = x.l_name,
                            License = x.licence,
                            DOB = x.dob,
                            Id = x.Id,
                            Issue_date = x.issue_date,
                            Mobile = x.mob,
                            Address = x.addr
                        });
                    }
                });
                if (resultCustomers.Count > 0)
                {
                    dataGridView1.DataSource = resultCustomers;
                }
                else
                {
                    MessageBox.Show("Customer doesn't exists!!");
                }
            }
        }
    }
}
