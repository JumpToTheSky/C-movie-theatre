using DemoMovieApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMovieApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text.ToString();
            String password = tbPassword.Text.ToString();

            if(username == null || password == null)
            {
                MessageBox.Show("Please enter both username and password");
            }

            if(LoginDAO.Instance().validateAccount(username, password))
            {
                MainForm form2 = new MainForm();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username and password not correct");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string hexColor = "#CAF0F8";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);

            this.BackColor = myColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            this.Hide();
            signupForm.ShowDialog();
            this.Close();
        }
    }
}
