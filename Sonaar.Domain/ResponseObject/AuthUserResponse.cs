﻿using Sonaar.Domain.Dto.Authentication;

namespace Sonaar.Domain.ResponseObject
{
	public class AuthUserResponse : LoginDto
    {
        public string Token { get; set; }

        public string Device { get; set; } = "Mobile";

        public DateTime LoginTime { get; set; }
    }
}

