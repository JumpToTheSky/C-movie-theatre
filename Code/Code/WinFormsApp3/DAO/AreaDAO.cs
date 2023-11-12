using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;

namespace LogInDemo.DAO
{
    public class AreaDAO
    {
        private static AreaDAO instance;
        public static AreaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AreaDAO();
                return instance;
            }
            private set => instance = value;
        }
        private AreaDAO()
        {
                
        }
        public List<Area> getAreaList()
        {
            List<Area> list = new List<Area>();
            string query = @"Select * from AREA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in data.Rows)
            {

                list.Add(new Area(row));
            }
            return list;
        }
    }
}
