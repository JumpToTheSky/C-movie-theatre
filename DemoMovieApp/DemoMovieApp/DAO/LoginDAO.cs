using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMovieApp.DAO
{
    class LoginDAO
    {
        private static LoginDAO _instance;
        private static Connection connection;

        public LoginDAO()
        {
            connection = new Connection();
        }
        public static LoginDAO Instance()
        {
            if (_instance == null)
            {
                _instance = new LoginDAO();
            }
            return _instance;
            
        }

        public bool validateAccount(String username, String password)
        {
            
            connection.openConnection();

            try
            {
                SqlCommand c = new SqlCommand("select * from KhachHang where soDienThoai = @username and matKhau = @password", connection.GetSqlConnection());
                
                c.Parameters.AddWithValue("@username", username);
                c.Parameters.AddWithValue("@password", password);
                
                SqlDataReader data = c.ExecuteReader();

                if (data.Read() == true)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.closeConnection();

            return false;
        }

    }
}
