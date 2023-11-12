using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LogInDemo.DTO
{
    public class User
    {
        private string username;
        private string password;
        private DateTime birthdate;
        private string email;
        private string phone;
        private string nid;
        private string name;
        private string gender;
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public DateTime Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Nid { get { return nid; } set { nid = value; } }
        public User(string username, string password, DateTime birthdate, string email, string phone, string nid, string name, string gender)
        {
            Username = username;
            Password = password;
            Birthdate = birthdate;
            Email = email;
            Phone = phone;
            Nid = nid;
            Name = name;
            Gender = gender;
        }
        public User(DataRow row)
        {
            Username = row["USERNAME"].ToString();
            Password = row["PASSWORD"].ToString();
            Birthdate = ((DateTime)row["BOD"]).Date;
            Email = row["EMAIL"].ToString();
            Nid = row["NID"].ToString();
            Name = row["NAME"].ToString();
            Phone = row["PHONE"].ToString();
            Gender = row["GENDER"].ToString();
        }
    }
}
