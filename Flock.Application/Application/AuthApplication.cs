using Flock.Application.Interfaces;
using Flock.Domain.DTOs.Church;
using Flock.Domain.Entities;
using Flock.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Application.Application
{
    public class AuthApplication : IAuthApplication
    {
        private readonly IAuthRepository _AuthRepository;

        public AuthApplication(IAuthRepository authRepository)
        {
            _AuthRepository = authRepository;
        }

        public Church CreateChurch(CreateChurchRequest church, Users user)
        {

            throw new NotImplementedException();
        }
    }
}
