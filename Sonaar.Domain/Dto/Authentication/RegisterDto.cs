﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sonaar.Domain.Dto.Authentication
{
	public class RegisterDto
	{
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

