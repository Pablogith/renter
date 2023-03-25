using Renter.Service.Application.Common.Interfaces.Persistence;
using Renter.Service.Domain.Entities;

namespace Renter.Service.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private readonly static List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return _users.SingleOrDefault(user => user.Email == email);
    }
}
