using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Application.DTOs.Member
{
    public class CreateMemberRequest
    {
       
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string phoneNumber { get; set; }

        public string email { get; set; }

        public DateOnly dateOfBirth { get; set; } 

    }
}
