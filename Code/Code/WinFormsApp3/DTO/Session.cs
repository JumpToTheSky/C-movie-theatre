using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class Session
    {
        private string id;
        private string mid;
        private int price;
        private DateTime date;
        private string format;
        private string subtitle;
        private string room;
        public string Id { get { return id; } set { id = value; } }
        public string Mid { get { return mid; } set { mid = value; } }
        public int Price { get { return price; } set { price = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string Format { get { return format; } set { format = value; } }
        public string Subtitle { get { return subtitle; } set { subtitle = value; } }
        public string Room { get { return room; } set { room = value; } }
        public Session(string id, string mid, int price, DateTime date, string format, string subtitle, string room)
        {
            Id = id;
            Mid = mid;
            Price = price;
            Date = date;
            Format = format;
            Subtitle = subtitle;
            Room = room;
        }
        public Session(DataRow row)
        {
            Id = row["SID"].ToString();
            Mid = row["MID"].ToString();
            Price = (int)row["PRICE"];
            Date = (DateTime)row["SD"];
            Format = row["MFORMAT"].ToString();
            Subtitle = row["SUBTITLE"].ToString();
            Room = row["RID"].ToString();
        }
    }
}
