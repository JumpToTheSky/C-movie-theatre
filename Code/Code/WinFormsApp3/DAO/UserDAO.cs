using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using LogInDemo.DTO;
namespace LogInDemo.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        private static DataTable __user;
        public  DataTable _user
        {
            get
            {
                string query = @"select * from CUSTOMER";
                __user = DataProvider.Instance.ExcuteQuery(query);
                    
                
                return __user;
            }
            set => __user = value;
        }
        

        #region method

        #endregion

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool logIn(string userName,string passWord)
        {
        for(int i=0;i<_user.Rows.Count;i++)
            {
                if (_user.Rows[i][0].ToString() == userName)
                {
                    if(_user.Rows[i][1].ToString() == passWord)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.\nPlease try again.");
                        return false;
                    }
                }    
            }
            MessageBox.Show("Log in has failed.\nPlease try again.");
            return false;
        }
        public bool signUp(string userName,string passWord,string name, string id, DateTime birthday, string email, string phone,string gender)
        {
            for (int i = 0; i < _user.Rows.Count; i++)
            {
                if (_user.Rows[i][0].ToString() == userName)
                {
              
                    MessageBox.Show("This username has already been used.\n");
                    return false;
                }
                if (_user.Rows[i][3].ToString() == id)
                {

                    MessageBox.Show("This ID has already been used.\n");
                    return false;
                }
                if (_user.Rows[i][4].ToString() == email)
                {

                    MessageBox.Show("This email has already been used.\n");
                    return false;
                }
                if (_user.Rows[i][6].ToString() == phone)
                {

                    MessageBox.Show("This phone number has already been used.\n");
                    return false;
                }
            }
            MessageBox.Show("Sign up successfully.");
            var line = string.Format(@"insert into CUSTOMER values('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}','{7}')", userName.ToString(), passWord.ToString(), name.ToString(), id.ToString(), birthday, email, phone,gender);
            DataProvider.Instance.ExcuteQuery(line);
            return true;
        }
        public bool forgotPassword(string username,string email)
        {
            for (int i = 0; i < _user.Rows.Count; i++)
            {
                if (_user.Rows[i][0].ToString() == username || _user.Rows[i][4].ToString() == email)
                {
                    MessageBox.Show("An email has been sent to your email.\nCheck your email to reset the password.");
                    return true;
                }
            }
            return false;
        }
        public User getAccount(string username,string password)
        {
            string query = @"Select * from Customer where username = '" + username + "' and password = '"+password+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            User user = new User(data.Rows[0]);
            return user;
        }
    }
}
