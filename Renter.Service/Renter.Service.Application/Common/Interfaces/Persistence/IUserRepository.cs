using Renter.Service.Domain.Entities;

namespace Renter.Service.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    void AddUser(User user);
}
