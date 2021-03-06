namespace Back.src.ContaMais.WebApi.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }        
    }
}