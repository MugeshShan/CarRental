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
    public partial class CategoryManagementPage : Form
    {
        CarRentalEntities db;
        public CategoryManagementPage()
        {
            InitializeComponent();
            db = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                name = textBox2.Text,
                descr = textBox2.Text
            };
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
