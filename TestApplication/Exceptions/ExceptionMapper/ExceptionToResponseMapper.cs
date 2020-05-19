using System;
using System.Net;
using Convey.WebApi.Exceptions;

namespace TestApplication.Exceptions.ExceptionMapper
{
    internal sealed class ExceptionToResponseMapper :IExceptionToResponseMapper
    {
        public ExceptionResponse Map(Exception exception)
            => exception switch
            {
                UnluckyException ex => new ExceptionResponse(new {code=ex.code,reason=ex.Message},HttpStatusCode.BadRequest),
                 _=> new ExceptionResponse(new {code="error", reason="There was an errror."},HttpStatusCode.InternalServerError)
            };
        
    }
}