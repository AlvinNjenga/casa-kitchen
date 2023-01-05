using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaKitchen.Application.Common.Interfaces.Persistence;
using CasaKitchen.Domain.Entities;

namespace CasaKitchen.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.FirstOrDefault(user => user.Email == email);
        }
    }
}