using System;
using System.Collections.Generic;
using System.Text;
using Flock.Application.DTOs.Member;
using Flock.Domain.DTOs.Church;
using Flock.Domain.Entities;

namespace Flock.Application.Interfaces
{
    public interface IAuthApplication
    {
        Church CreateChurch(CreateChurchRequest church, Users user);
        
    }
}
