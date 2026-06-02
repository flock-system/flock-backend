using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Domain.Entities
{
    public class Member
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public string email { get; set; }

        public DateOnly dateOfBirth { get; set; }

        public bool isActive { get; set; }

        public DateOnly createdAt { get; set; }

        public Guid tenantId { get; set; }
    }
}
