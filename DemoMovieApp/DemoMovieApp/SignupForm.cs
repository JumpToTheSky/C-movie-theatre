using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMovieApp.DAO;


namespace DemoMovieApp
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            String name = tbName.Text.ToString();
            String phone = tbPhone.Text.ToString();
            String password = tbPassword.Text.ToString();
            String birday = tbBirthday.Text.ToString();
            String address = tbAddress.Text.ToString();

            if(name == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            }
            if (phone == "")
            {
                MessageBox.Show("Please enter your phone");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Please enter your password");
                return;
            }
            if (birday == "")
            {
                MessageBox.Show("Please enter your birthday");
                return;
            }
            if (address == "")
            {
                MessageBox.Show("Please enter your address");
                return;
            }

            if(SingupDAO.Instance().insertAcc(name, phone, password, birday, address))
            {
                MainForm form2 = new MainForm();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail");
            }

        }
    }
}
