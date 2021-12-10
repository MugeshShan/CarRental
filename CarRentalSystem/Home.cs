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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void NewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarPage car = new CarPage();
            car.ShowDialog();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            customerPage.ShowDialog();
        }

        private void CustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomer = new SearchCustomer();
            searchCustomer.ShowDialog();
        }

        private void RentalCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentCar car = new RentCar();
            car.ShowDialog();
        }

        private void CarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCar searchCar = new SearchCar();
            searchCar.ShowDialog();
        }

        private void categoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagementPage category = new CategoryManagementPage();
            category.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();
            paymentPage.ShowDialog();
        }
    }
}
