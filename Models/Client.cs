using System;

namespace PortalMost_WebAPI.Models
{
    public class Client
    {   
        public Client() { }

        public Client(int id, int UserId, string name, string email, string birthDate)
        {
            this.id = id;
            this.UserId = UserId;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
        public int id { get; set; }
        public int UserId { get; set; }
        public User UserInfo { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string birthDate { get; set; }
        
    }
}