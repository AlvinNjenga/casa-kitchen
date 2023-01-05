using CasaKitchen.Domain.Entities;

namespace CasaKitchen.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}