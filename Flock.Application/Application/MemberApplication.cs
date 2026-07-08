using Flock.Application.DTOs.Member;
using Flock.Application.Interfaces;
using Flock.Domain.Entities;
using Flock.Infrastructure.Interfaces;
using System.Text.RegularExpressions;
using System.Security.Claims;

namespace Flock.Application.Application
{
    public class MemberApplication : IMemberApplication
    {
        private readonly IMemberRepository _memberRepository;

        public MemberApplication(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public Member CreateMember(CreateMemberRequest request, Guid tenantId)
        {
            

            
            var member = new Member
            {
                firstName = request.firstName,
                lastName = request.lastName,
                phoneNumber = request.phoneNumber,
                email = request.email,
                dateOfBirth = request.dateOfBirth,
                createdAt = DateOnly.FromDateTime(DateTime.Today),
                isActive = true,
                tenantId = tenantId


            };

            (bool flowControl, Member value) = ValidationMember(member);

            if (!flowControl)
            {
                return value;
            }

            var memberRegistered = _memberRepository.CreateMember(member);

            return memberRegistered;
        }

        private static (bool flowControl, Member value) ValidationMember(Member member)
        {
            //Fazendo as validações
            bool isValidName = Regex.IsMatch(member.firstName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$") && Regex.IsMatch(member.lastName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$");
            bool isValidPhoneNumber = Regex.IsMatch(member.phoneNumber, @"^[0-9()+\s-]+$");

            //validações
            if (!isValidPhoneNumber) return (flowControl: false, value: null);

            if (!isValidName) return (flowControl: false, value: null);

            if (!validateDateOfBirth(member.dateOfBirth.ToString())) return (flowControl: false, value: null);

            return (flowControl: true, value: null);
        }

        private static bool validateDateOfBirth(string input)
        {
            string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };
            return DateTime.TryParseExact(input, formats, null, System.Globalization.DateTimeStyles.None, out _);
        }

        

    }
}
