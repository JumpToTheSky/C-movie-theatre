using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;

namespace LogInDemo.DAO
{
    public class SessionDAO
    {
        private static SessionDAO instance;
        public static SessionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SessionDAO();
                return instance;
            }
            private set => instance = value;
        }
        public static int height = 78;
        public static int width = 455;
        private SessionDAO()
        {

        }
        public List<Session> getSessionListByIn4(string room, DateTime date, string movie)
        {
            List<Session> list = new List<Session>();
            string query = @"Select * from Session where rid = '" + room+"' and cast(sd as date) = '" + date.Date + "' and mid = '" + movie + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Session(row));
            }
            return list;
        }
        public List<Session> getSessionListByCID(string cid, DateTime date, string movie)
        {
            List<Session> list = new List<Session>();
            List<Room> dataRoom = RoomDAO.Instance.getRoomListByCine(cid);
            foreach (Room r in dataRoom)
            {

                list.AddRange(getSessionListByIn4(r.Id,date,movie));
            }
            return list;
        }
    }
}
