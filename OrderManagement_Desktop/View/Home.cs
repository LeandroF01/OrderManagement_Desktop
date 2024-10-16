using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement_Desktop.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonViewProducts_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();

            productsForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ButtonViewOrders_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();

            ordersForm.ShowDialog();
        }
    }
}

