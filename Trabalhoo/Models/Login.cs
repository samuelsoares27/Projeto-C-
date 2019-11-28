using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalhoo.Models
{
    [Dapper.Contrib.Extensions.Table("users")]
    public class Login
    {
        [Column("id")]
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("username")]
        public string Username { get; set; }
    }
}
