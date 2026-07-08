using Flock.Domain.Entities;
using Flock.Infrastructure.Interfaces;
using Flock.Infrastructure.Persistance;

namespace Flock.Infrastructure.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _context;

        public MemberRepository(AppDbContext context)
        {
            _context = context;
        }
        public Member CreateMember(Member member) 
        {
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Message: {e.Message}"); ;
            }

            return member;
        }

      
    }
}
