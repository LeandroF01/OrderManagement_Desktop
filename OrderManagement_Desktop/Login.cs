using OrderManagement_Desktop.Models;
using OrderManagement_Desktop.Services;
using System.Windows.Forms;
using System;
using System.Configuration;
using OrderManagement_Desktop.View;

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


        private async void Login_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = GetEmailFromConfig();
        }


        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            var Login = new Models.Login
            {
                Email = textBoxEmail.Text,
                Password = textBoxPass.Text
            };
            string token = await _authServices.Login(Login);



            if (!string.IsNullOrEmpty(token) && !token.Contains("Incorrect password."))
            {
                SaveEmailToConfig(Login.Email);
                MessageBox.Show(token);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }


        private void SaveEmailToConfig(string email)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UserEmail"].Value = email;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private string GetEmailFromConfig()
        {
            return ConfigurationManager.AppSettings["UserEmail"];
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();

            registerForm.ShowDialog();
        }
    }
}
