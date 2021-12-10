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
    public partial class SearchCar : Form
    {
        CarRentalEntities db;
        public SearchCar()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cars = db.Cars.ToList();
            var resultCars = new List<CarModel>();
            cars.ForEach(x =>
            {
                if (x.car_no == textBox1.Text)
                {
                    resultCars.Add(new CarModel { 
                        Brand_name = x.brand_name,
                        Car_name = x.car_name,
                        Car_no = x.car_no,
                        Category = x.category,
                        Colour = x.colour,
                        Mfg_date = x.mfg_date,
                        Milage = x.milage,
                        Id = x.Id,
                        Insurance_no = x.insurance_no
                    });
                }
            });

            if(resultCars.Count > 0)
            {
                dataGridView1.DataSource = resultCars;
            }
            else
            {
                MessageBox.Show("Car doesn't exists");
            }
        }
    }
}
