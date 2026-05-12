using Flock.Domain.Entities;

namespace Flock.Infrastructure.Interfaces
{
    public interface IMemberRepository
    {
        Member CreateMember(Member member);
    }
}
