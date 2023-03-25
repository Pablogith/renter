using Renter.Service.Application.Common.Interfaces.Services;

namespace Renter.Service.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
