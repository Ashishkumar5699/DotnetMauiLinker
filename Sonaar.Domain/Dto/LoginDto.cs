using System;
using System.ComponentModel.DataAnnotations;
using Sonaar.Domain.Models.Auth;

namespace Sonaar.Domain.Dto
{
	public class LoginDto
    {
        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}

