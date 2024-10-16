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


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ButtonViewOrders_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();

            ordersForm.ShowDialog();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Asegúrate de que el nombre del panel coincida con el del diseñador.
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void ButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
           openChildForm(new Products());

        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTables_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPayments_Click(object sender, EventArgs e)
        {

        }

        private void ButtonConfiguration_Click(object sender, EventArgs e)
        {

        }
    }
}

