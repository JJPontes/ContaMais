using System.ComponentModel.DataAnnotations;

namespace Back.src.ContaMais.WebApi.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PerfilImg { get; set; }        
    }
}