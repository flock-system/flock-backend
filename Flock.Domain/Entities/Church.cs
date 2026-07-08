using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Domain.Entities
{
    public class Church
    {
        public int id { get; set; }

        public string name { get; set; }

        public Guid tenantId { get; set; }

        public string email { get; set; }

        public string password { get; set; }

    }
}
