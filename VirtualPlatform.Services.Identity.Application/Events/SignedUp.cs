using System;
using Convey.CQRS.Events;

namespace VirtualPlatform.Services.Identity.Application.Events
{
    [Contract]
    public class SignedUp : IEvent
    {
        public Guid UserId { get; }
        public string Email { get; }
        public string Role { get; }

        public SignedUp(Guid userId, string email, string role)
        {
            UserId = userId;
            Email = email;
            Role = role;
        }
    }
}