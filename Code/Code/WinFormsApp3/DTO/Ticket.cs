using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class Ticket
    {
        private string id;
        private string bid;
        private string chair;
        public string Id { get { return id; } set { id = value; } }
        public string Bid { get { return bid; } set { bid = value; } }
        public string Chair { get { return chair; } set { chair = value; } }
        public Ticket(string id, string bid, string chair)
        {
            this.id = id;
            this.bid = bid;
            this.chair = chair;
        }
        public Ticket(DataRow row)
        {
            this.id = row["TID"].ToString();
            this.bid = row["BID"].ToString();
            this.chair = row["CHAIR"].ToString();
        }
    }
}
