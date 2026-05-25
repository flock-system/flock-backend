using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Domain.DTOs.Auth
{
    public class LoginRequest
    {
        public string username {  get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

    }
}
