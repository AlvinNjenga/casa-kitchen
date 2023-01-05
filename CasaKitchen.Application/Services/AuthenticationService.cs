using CasaKitchen.Application.Common.Interfaces.Authentication;
using CasaKitchen.Application.Common.Interfaces.Persistence;
using CasaKitchen.Application.Services.Interfaces;
using CasaKitchen.Domain.Entities;

namespace CasaKitchen.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepo;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepo)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepo = userRepo;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if user already exists
        if (_userRepo.GetUserByEmail(email) is not null)
            throw new Exception("User with given email already exists");

        // Create user (generate unique ID) & persist the user
        User user = new()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepo.Add(user);


        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        // 1. Validate the user exists.
        if (_userRepo.GetUserByEmail(email) is not User user)
            throw new Exception("User with given email doesn't exist");

        // 2. Validate the password is correct
        if (user.Password != password)
            throw new Exception("Invalid password");


        // 3. Create the JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}
