namespace Renter.Service.Application.Common.Interfaces.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
