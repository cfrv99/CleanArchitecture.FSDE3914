using System;

namespace FirstApi.Domain.Commons.Exceptions
{
    public class ApiException : ApplicationException
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public ApiException(string message, string statusCode) : base(message)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
