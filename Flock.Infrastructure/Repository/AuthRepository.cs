using Flock.Domain.Entities;
using Flock.Infrastructure.Interfaces;
using Flock.Infrastructure.Persistance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flock.Infrastructure.Repository
{
    public class AuthRepository : IAuthRepository
    {
        public readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }
        public Church CreateChurch(Church church)
        {
            try
            {
                _context.Church.Add(church);
                _context.SaveChanges();
            }
            catch (Exception e){
                throw new Exception($"Message: {e.Message}");
            }

            return church;

        }
        public Users CreateUser(Users user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Message: {e.Message}");
            }
            

            return user;
        }
    }
}
