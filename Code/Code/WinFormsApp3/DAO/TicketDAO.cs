using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;
namespace LogInDemo.DAO
{
    internal class TicketDAO
    {
        private static TicketDAO instance;
        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<string> getLeftChairList()
        {
            List<string> list = new List<string>();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach(char s in alpha)
            { 
                for(int i=1;i<=5;i++)
                {
                    list.Add(s.ToString()+i.ToString("00"));
                }
                if(s.ToString()=="P")
                {
                    break;
                }
            }
            return list;
        }
        public List<string> getRightChairList()
        {
            List<string> list = new List<string>();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (char s in alpha)
            {
                for (int i = 25; i <= 29; i++)
                {
                    list.Add(s.ToString() + i.ToString("00"));
                }
                if (s.ToString() == "P")
                {
                    break;
                }
            }
            return list;
        }
        public List<string> getMiddleChairList()
        {
            List<string> list = new List<string>();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (char s in alpha)
            {
                for (int i = 1; i <= 29; i++)
                {
                    list.Add(s.ToString() + i.ToString("00"));
                }
                if (s.ToString() == "P")
                {
                    break;
                }
            }
            return list;
        }
        private TicketDAO()
        {

        }
        public List<Ticket> getTicketList(string bid)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from Ticket where BID = '" + bid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Ticket(row));
            }
            return list;
        }
        public List<Ticket> getTicketListIn4(string sid,string username)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from BILL where SID = '" + sid + "' AND USERNAME = '" + username + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.AddRange(getTicketList(row["BID"].ToString()));
            }
            return list;
        }
        public List<Ticket> getTicketListFromSID(string sid)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from BILL where SID = '" + sid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.AddRange(getTicketList(row["BID"].ToString()));
            }
            return list;
        }
    }
}
