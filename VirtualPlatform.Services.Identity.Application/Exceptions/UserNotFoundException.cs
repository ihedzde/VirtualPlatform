using System;

namespace VirtualPlatform.Services.Identity.Application.Exceptions
{
    public class UserNotFoundException : AppException
    {
        public override string Code { get; } = "user_not_found";
        public Guid UserId { get; }

        public UserNotFoundException(Guid userId) : base($"User with ID: '{userId}' was not found.")
        {
            UserId = userId;
        }
    }
}