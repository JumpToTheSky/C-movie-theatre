using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class Cinema
    {
        private string id;
        private string name;
        private string aid;
        public string Id {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name { 
            get {
                return name;
            }
            set
            {
                name = value;
            } 
        }
        public string Aid { get
            {
                return aid;
            } 
            set
            { aid = value;}
        }
        public Cinema(string id, string name, string aid)
        {
            Id = id;
            Name = name;
            Aid = aid;
        }
        public Cinema(DataRow row)
        {
            this.Id = row["CID"].ToString();
            this.Name = row["CNAME"].ToString();
            this.Aid = row["AID"].ToString();
        }
    }
}
