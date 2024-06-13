using System.Net;
using System.Text.Json;

namespace API.Extensions;

public class ExceptionHandlingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var responseMessage = ex switch
        {
            _ => new
            {
                Status = HttpStatusCode.InternalServerError,
                ex.Message
            }
        };

        var response = JsonSerializer.Serialize(responseMessage);

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        await context.Response.WriteAsJsonAsync(response);
    }
}