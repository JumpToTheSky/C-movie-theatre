using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LogInDemo.DTO;
namespace LogInDemo.DAO
{
    public class MovieDAO
    {
        private static MovieDAO instance;
        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MovieDAO();
                return instance;
            }
            private set => instance = value;
        }
        private MovieDAO() { }
        public List<Movie> getMovieList()
        {
            List<Movie> list = new List<Movie>();
            string query = @"Select * from Movie";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Movie(row));
            }
            return list;
        }
    }
}
