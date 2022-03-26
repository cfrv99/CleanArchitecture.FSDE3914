using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Responses
{
    public class ApiResponse<T> where T : IDto
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccess { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public T Data { get; set; }

        public ApiResponse(T data)
        {
            Data = data;
            ErrorMessage = "";
            IsSuccess = true;
        }

        public ApiResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsSuccess = false;
        }
    }

    public class ValidationError
    {
        public string FieldName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
