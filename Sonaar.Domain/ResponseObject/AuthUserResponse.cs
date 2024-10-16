using Sonaar.Domain.Dto.Authentication;

namespace Sonaar.Domain.ResponseObject
{
	public class AuthUserResponse : LoginDto
    {
        public string Token { get; set; }

        public DateTime LoginTime { get; set; }
    }
}

