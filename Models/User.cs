namespace PortalMost_WebAPI.Models
{
    public class User
    {   
        public User() { }

        public User(int id, string username, string email, string type)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.type = type;
        }
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        
    }
}