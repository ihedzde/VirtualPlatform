using Microsoft.AspNetCore.Identity;
using VirtualPlatform.Services.Identity.Application.Services;

namespace VirtualPlatform.Services.Identity.Infrastructure.Auth;

public class PasswordService : IPasswordService
{
    private readonly IPasswordHasher<IPasswordService> _passwordHasher;

    public PasswordService(IPasswordHasher<IPasswordService> passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }

    public bool IsValid(string hash, string password)
        => _passwordHasher.VerifyHashedPassword(this, hash, password) != PasswordVerificationResult.Failed;

    public string Hash(string password)
        => _passwordHasher.HashPassword(this, password);
}