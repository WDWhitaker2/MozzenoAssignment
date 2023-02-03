using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Net.Http;

namespace Mozzeno.API.ExceptionFilter
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string exceptionMessage = string.Empty;
            if (actionExecutedContext.Exception.InnerException == null)
            {
                exceptionMessage = actionExecutedContext.Exception.Message;
            }
            else
            {
                exceptionMessage = actionExecutedContext.Exception.InnerException.Message;
            }
            //We can log this exception message to the file or database.
            var response = new HttpResponseMessage(actionExecutedContext.Response.StatusCode)
            {
                    Content =  new StringContent("An unhandled exception was thrown by service."),
                    ReasonPhrase = "Internal Server Error.Please Contact your Administrator."
            };
            actionExecutedContext.Response = response;
        }
    }
}