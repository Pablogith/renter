using Renter.Service.Domain.Entities;

namespace Renter.Service.Application.Models;

public record AuthenticationResult(
    User User,
    string Token
    );
