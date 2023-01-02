namespace CasaKitchen.Application.Services.Interfaces;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName, string lastname, string email, string password);
    AuthenticationResult Login(string email, string password);
};
