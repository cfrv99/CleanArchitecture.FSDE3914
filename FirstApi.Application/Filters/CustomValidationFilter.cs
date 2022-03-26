using FirstApi.Domain.Commons.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Filters
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ApiResponse<IDto> apiResponse = new ApiResponse<IDto>("Validation Error");
                var modelErrors = context.ModelState.Keys.SelectMany(key => context.ModelState[key].Errors.Select(error => new ValidationError
                {
                    FieldName = key,
                    ErrorMessage = error.ErrorMessage
                }));
                apiResponse.ValidationErrors = new List<ValidationError>();
                apiResponse.ValidationErrors.AddRange(modelErrors);

                context.Result = new BadRequestObjectResult(apiResponse);
            }
        }
    }
}
