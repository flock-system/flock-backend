using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Domain.Entities
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public int adminLevel { get; set; }

        public Guid tenantId { get; set; }
        


    }
}
