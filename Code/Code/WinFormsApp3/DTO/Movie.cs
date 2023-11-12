using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class Movie
    {
        private string id;
        private string name;
        private string director;
        private TimeSpan length;
        public string Id { get { return id; } set { id = value; } } 
        public string Name { get { return name; } set { name = value; } }   
        
        public string Director { get { return director; } set { director = value; } }
        public TimeSpan Length { get { return length; } set { length = value; } }

        public Movie(string id, string name, string director, TimeSpan length)
        {
            Id = id;
            Name = name;
            Director = director;
            Length = length;
        }
        public Movie(DataRow row)
        {
            Id = row["MID"].ToString();
            Name = row["MNAME"].ToString();
            Director = row["DIRECTOR"].ToString();
            Length = (TimeSpan)row["LENGTH"];
        }
    }
}
