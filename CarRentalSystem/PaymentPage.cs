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
    public partial class PaymentPage : Form
    {
        CarRentalEntities db;
        public PaymentPage()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var payments = db.Payments.ToList();
            var resultPayment = new List<PaymentModel>();
            var date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            payments.ForEach(x =>
            {
                if (x.date.ToString("MM/dd/yyyy") == date)
                {
                    resultPayment.Add(new PaymentModel 
                    { 
                        Amount = x.amount,
                        Payment_id = (int)x.payment_id,
                        Status = x.status,
                        Date = x.date
                    });
                }
            });
            if(resultPayment.Count > 0)
            {
                dataGridView1.DataSource = resultPayment;
            }
            else
            {
                MessageBox.Show("No Payment done !!");
            }
        }
    }
}
