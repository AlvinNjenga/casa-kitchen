using CasaKitchen.Domain.Entities;

namespace CasaKitchen.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        void Add(User user);
        User? GetUserByEmail(string email);
    }
}