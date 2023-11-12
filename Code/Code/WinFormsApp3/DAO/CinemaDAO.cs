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
    public class CinemaDAO
    {
        private static CinemaDAO instance;
        public static CinemaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CinemaDAO();
                return instance;
            }
            private set => instance = value;
        }
        private CinemaDAO() { }
        public List<Cinema> getCinemaListByAID(string aid)
        { 
            List<Cinema> list = new List<Cinema>();
            string query = @"Select * from CINEMA where AID = '" + aid +"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Cinema(row));
            }
            return list;
        }
    }
}
