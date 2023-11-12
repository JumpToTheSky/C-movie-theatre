using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class Room
    {
        private string id;
        private int number;
        private string cid;
        public string Id { get { return id; } set { id = value; } }
        public string Cid { get { return cid; } set { cid = value; } }
        public int Number { get { return number; } set { number = value; } }
        public Room(string id, int number, string cid)
        {
            Id = id;
            Cid = cid;
            Number = number;
        }
        public Room(DataRow row)
        {
            Id = row["RID"].ToString();
            number = (int)row["RNUMBER"];
            Cid = row["CID"].ToString();
        }
    }
}
