using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace DemoMovieApp.DAO
{
    
    public class SingupDAO
    {
        private static Connection connection;
        private static SingupDAO _instance;

        public SingupDAO()
        {
            connection = new Connection();
        }

        public static SingupDAO Instance()
        {
            if (_instance == null)
            {
                _instance = new SingupDAO();
            }
            return _instance;

        }

        public bool insertAcc(String name, String phone, String password, String birthday, String address)
        {
            connection.openConnection();

            try
            {
                SqlCommand c = new SqlCommand("select * from KhachHang where soDienThoai = @phone", connection.GetSqlConnection());

                c.Parameters.AddWithValue("@phone", phone);

                SqlDataReader data = c.ExecuteReader();

                if (data.Read() == true)
                {
                    //Account had exist
                    MessageBox.Show("Account had exist in system");
                    connection.closeConnection();
                    return false;
                }
                else
                {
                    data.Close();
                    //insert account
                    String sql = "INSERT INTO KhachHang(matKhau, tenKhachHang, soDienThoai, ngaysinh, diaChi, diemTichLuy) VALUES (@matkhau,@ten ,@sdt ,'12/4/2002',@diachi, @diemtichluy);";

                    SqlCommand cmd = new SqlCommand(sql, connection.GetSqlConnection());

                    cmd.Parameters.AddWithValue("@matkhau", password);
                    cmd.Parameters.AddWithValue("@ten", name);
                    cmd.Parameters.AddWithValue("@sdt", phone);
                    cmd.Parameters.AddWithValue("@diachi", address);
                    cmd.Parameters.AddWithValue("@diemtichluy", 0);

                    SqlDataReader data1 = cmd.ExecuteReader();

                    //Account had exist
                    MessageBox.Show("Account Successful");
                    connection.closeConnection();
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
