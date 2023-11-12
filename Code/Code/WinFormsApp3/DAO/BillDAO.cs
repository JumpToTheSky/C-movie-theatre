using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;
namespace LogInDemo.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set => instance = value;
        }
        private BillDAO()
        {

        }
        public List<Bill> getBillList(string sid)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where SID = '" + sid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
        public List<Bill> getBillList(string sid,string username)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where SID = '" + sid + "' and USERNAME = '" + username +"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
        public List<Bill> getUserBill(string username)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where USERNAME = '" + username + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
    }
}
