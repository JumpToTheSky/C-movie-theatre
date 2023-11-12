using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;

namespace LogInDemo.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomDAO();
                return instance;
            }
            private set => instance = value;
        }
        private RoomDAO()
        {

        }
        public List<Room> getRoomListByCine(string cid)
        {
            List<Room> list = new List<Room>();
            string query = @"Select * from Room where CID = '" + cid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Room(row));
            }
            return list;
        }
    }
}
