using System.ComponentModel.DataAnnotations;

namespace BTH2.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Token { get; set; }
    }
}

