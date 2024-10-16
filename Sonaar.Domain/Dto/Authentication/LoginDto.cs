using System;
using System.ComponentModel.DataAnnotations;

namespace Sonaar.Domain.Dto.Authentication
{
	public class LoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string Device { get; set; } = "Mobile";

    }
}

