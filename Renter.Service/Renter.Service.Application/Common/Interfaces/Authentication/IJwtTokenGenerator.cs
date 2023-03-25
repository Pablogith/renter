using Renter.Service.Domain.Entities;

namespace Renter.Service.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
