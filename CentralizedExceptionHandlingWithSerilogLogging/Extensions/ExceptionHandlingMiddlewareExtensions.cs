namespace CentralizedExceptionHandlingWithSerilogLogging.Extensions
{
    using CentralizedExceptionHandlingWithSerilogLogging.Middlewares;
    using Microsoft.AspNetCore.Builder;
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseCentralizedExceptionHandling(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
