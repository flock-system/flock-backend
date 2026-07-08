using Flock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Infrastructure.Interfaces
{
    public interface IAuthRepository
    {

        Church CreateChurch(Church church);
        Users CreateUser(Users user);
    }
}
