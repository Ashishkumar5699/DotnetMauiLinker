using System.ComponentModel.DataAnnotations;

namespace Sonaar.Domain.Models.Auth
{
    public class AuthUser
    {
        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }

        public string Token { get; set; }

        public string Device { get; set; } = "Mobile";

    }
}
