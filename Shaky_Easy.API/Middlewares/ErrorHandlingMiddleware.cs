using System.Net;
using System.Text.Json;

namespace Shaky_Easy.API.Middlewares
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {

                await HandleExceptionAsync(context,ex);
            }
        }



        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

             await context.Response.WriteAsJsonAsync("An error occurred while processing your request");
        }
    }
}
