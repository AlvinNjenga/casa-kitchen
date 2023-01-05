using CasaKitchen.Domain.Entities;

namespace CasaKitchen.Application.Services;

public record AuthenticationResult(
    User User,
    string Token
);
