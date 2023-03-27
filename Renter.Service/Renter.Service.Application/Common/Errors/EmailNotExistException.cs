using System.Net;

namespace Renter.Service.Application.Common.Errors;

public class EmailNotExistException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.NotFound;

    public string ErrorMessage => "User with given data email does not exist.";
}
