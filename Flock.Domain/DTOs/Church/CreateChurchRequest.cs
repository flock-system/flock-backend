using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Domain.DTOs.Church
{
    public class CreateChurchRequest
    {
        public string churchName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string userName { get; set; }


    }
}
