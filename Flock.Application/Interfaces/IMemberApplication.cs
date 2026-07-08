using Flock.Application.DTOs.Member;
using Flock.Domain.Entities;

namespace Flock.Application.Interfaces
{
    public interface IMemberApplication
    {
        Member CreateMember(CreateMemberRequest request, Guid tenantId);

        
    }
}
