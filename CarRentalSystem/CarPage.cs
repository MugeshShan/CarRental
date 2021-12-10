using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class CarPage : Form
    {
        CarRentalEntities db;
        public CarPage()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var car = new Car
            {
                car_name = textBox1.Text,
                car_no = textBox2.Text,
                category = textBox3.Text,
                brand_name = textBox4.Text,
                colour = textBox5.Text,
                mfg_date = textBox6.Text,
                milage = textBox7.Text,
                insurance_no = textBox8.Text
            };
            var cars = db.Cars.ToList();
            if (cars.Count > 0)
            {
                cars.ForEach(x =>
                {
                    if (x.car_no == textBox2.Text)
                    {
                        MessageBox.Show("Car number already exists");
                    }
                    else
                    {
                        db.Cars.Add(car);
                        db.SaveChanges();
                        MessageBox.Show("Car added : " + textBox2.Text);
                    }
                });
            }
            else
            {
                db.Cars.Add(car);
                db.SaveChanges();
                MessageBox.Show("Car added : " + textBox2.Text);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

                
                var car = new Car
                {
                    car_name = textBox1.Text,
                    car_no = textBox2.Text,
                    category = textBox3.Text,
                    brand_name = textBox4.Text,
                    colour = textBox5.Text,
                    mfg_date = textBox6.Text,
                    milage = textBox7.Text,
                    insurance_no = textBox8.Text
                };
                db.Cars.Add(car);
                db.SaveChanges();
                MessageBox.Show("Car Updated : " + textBox2.Text);
                
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                var cars = db.Cars.ToList();
                cars.ForEach(x =>
                {
                    if (x.car_no == textBox2.Text)
                    {
                        textBox1.Text = x.car_name;
                        textBox2.Text = x.car_no;
                        textBox3.Text = x.category;
                        textBox4.Text = x.brand_name;
                        textBox5.Text = x.colour;
                        textBox6.Text = x.mfg_date;
                        textBox7.Text = x.milage;
                        textBox8.Text = x.insurance_no;
                    }
                });
            }
            else
            {
                MessageBox.Show("Please enter car number");
            }
        }
    }
}
