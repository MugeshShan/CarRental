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
    public partial class RentCar : Form
    {
        CarRentalEntities db;
        public RentCar()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rental = new rental
            {
                car = textBox1.Text,
                c_name = textBox2.Text,
                from_date = textBox3.Text,
                return_date = textBox4.Text,
                total = textBox5.Text,
                date = DateTime.Now
            };
            var cars = db.Cars.ToList();
            var customers = db.Customers.ToList();
            bool carfound = false;
            bool custFound = false;
            foreach(var car in cars)
            {
                if(car.car_no == textBox1.Text)
                {
                    carfound = true;
                    rental.car_id = car.Id;
                    break;
                }
            }
            foreach(var customer in customers)
            {
                if (customer.f_name.Equals(textBox2.Text))
                {
                    custFound = true;
                    rental.cust_id = customer.Id;
                    break;
                }
            }

            if(custFound && carfound)
            {
                db.rentals.Add(rental);
                db.SaveChanges();
                var rentalCount = db.rentals.ToList();
                var payment = new Payment
                {
                    payment_id = rentalCount.Count,
                    status = "Successfull",
                    date = rental.date,
                    amount = rental.total
                };
                db.Payments.Add(payment);
                db.SaveChanges();
                MessageBox.Show("Payment done !!");
            }
            else
            {
                MessageBox.Show("Car number or Customer Name are incorrect !!");
            }
        }
    }
}
