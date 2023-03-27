using Renter.Service.Domain.Entities;

namespace Renter.Service.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
    );
