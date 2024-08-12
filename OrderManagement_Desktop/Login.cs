using OrderManagement_Desktop.Models;
using OrderManagement_Desktop.Services;
using System.Windows.Forms;
using System;

namespace OrderManagement_Desktop
{
    public partial class Login : Form
    {

        private readonly AuthServices _authServices;

        public Login()
        {
            InitializeComponent();
            _authServices = new AuthServices();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Crear una nueva instancia del formulario de login
        //    Login loginForm = new Login();

        //    // Mostrar el formulario de login como un cuadro de diálogo modal
        //    loginForm.ShowDialog();
        //}



        private async void Login_Load(object sender, EventArgs e)
        {
           
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            var Login = new Models.Login
            {
                Email = textBoxEmail.Text,
                Password = textBoxPass.Text
            };
            string token = await _authServices.Login(Login);

        

            if (!string.IsNullOrEmpty(token) && !token.Contains("Incorrect password."))
            {
                MessageBox.Show(token);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
