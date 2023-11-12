using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovieApp.DAO
{
    class Connection
    {
        SqlConnection conn;

        public Connection()
        {
            conn = new SqlConnection("Data Source=LAPTOP-17UNACAQ;Initial Catalog=CINEMA;User ID=sa;Password=12345678");
        }
        public SqlConnection GetSqlConnection()
        {
            return conn;
        }
        public void openConnection()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
    }
}
