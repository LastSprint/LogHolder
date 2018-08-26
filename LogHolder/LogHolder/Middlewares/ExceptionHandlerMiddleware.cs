using System;
using System.Net;
using System.Threading.Tasks;

using LogHolderAPI.Exceptions;

using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

namespace LogHolderAPI.Middlewares {

    public class ExceptionHandlerMiddleware: IMiddleware {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next) {
            try {
                await next(context);
            }
            catch (Exception exception) {
                await this.HandleExceptionAsync(context, exception);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception) {
            var statusCode = HttpStatusCode.InternalServerError;
            switch (exception) {
                case RequriedFieldNotSetExceptioncs value:
                    statusCode = HttpStatusCode.BadRequest;
                    break;
            }

            context.Response.ContentType = "Application/json";
            context.Response.StatusCode = (int)statusCode;
            var response = JsonConvert.SerializeObject(new {error = exception.Message});
            return context.Response.WriteAsync(response);
        }

    }

}
