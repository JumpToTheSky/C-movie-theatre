using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DAO;
namespace LogInDemo
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        bool CheckError()
        {
            if(tbUserName.Text==""||tbPassWord.Text==""||tbRePassWord.Text==""||name.Text==""||id.Text==""||email.Text==""||birthday.Text == "" ||phone.Text == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;

            }
            if (tbPassWord.Text.Length < 8)
            {
                MessageBox.Show("Password must be longer than 8 characters");
                return false;
            }
            if (tbPassWord.Text!=tbRePassWord.Text)
            {
                MessageBox.Show("Password does not match");
                return false;
            }
            if(name.Text.Length<2)
            {
                MessageBox.Show("Name must be longer than 2 characters");
                return false;
            }
            if(!checkBox1.Checked)
            {
                MessageBox.Show("You must agree to our Terms of Use and Privacy Notice.");
                return false;
            }
            return true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                string gender = new string("");
                if (genderF.Checked==true)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                if(UserDAO.Instance.signUp(tbUserName.Text, tbPassWord.Text, name.Text,id.Text,birthday.Value, email.Text, phone.Text,gender))
                    this.Close();
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbRePassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
