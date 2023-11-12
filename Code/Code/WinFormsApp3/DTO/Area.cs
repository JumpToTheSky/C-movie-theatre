using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LogInDemo.DTO
{
    public class Area
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Area(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Area(DataRow row)
        {
            this.Id = row["AID"].ToString();
            this.Name = row["ANAME"].ToString();
        }
    }
}
