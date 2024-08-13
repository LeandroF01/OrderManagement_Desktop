using OrderManagement_Desktop.Models;
using OrderManagement_Desktop.Services;
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
    public partial class Register : Form
    {

        private UserServices _userServices;

        public Register()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private async void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new Users
                {
                    Name = textBoxName.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPass.Text,
                    Phone = textBoxPhone.Text,
                    Address = textBoxAddres.Text,
                    UserType = "Normal"
                };

                bool isSuccess = await _userServices.AddUser(newUser);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario agregado exitosamente.");

                    Login loginForm = new Login();

                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al agregar el usuario.");
                }
            }
            catch (Exception ex)
            {
                // Muestra detalles de la excepción
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
