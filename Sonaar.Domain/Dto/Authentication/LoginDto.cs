using System;
using System.ComponentModel.DataAnnotations;

namespace Sonaar.Domain.Dto.Authentication
{
	public class LoginDto
    {
        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}

