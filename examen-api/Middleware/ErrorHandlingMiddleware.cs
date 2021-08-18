using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using API.Application.Constants;
using API.Application.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace API.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionError(context, ex, _logger);
            }
        }

        private async Task HandleExceptionError(HttpContext context, Exception ex, ILogger<ErrorHandlingMiddleware> logger)
        {
            object errors = null;
            context.Response.ContentType = GlobalConstants.APPLICATION_TYPE_JSON;

            switch (ex)
            {
                case RestException rest:
                    logger.LogError(ex, GlobalConstants.REST_ERROR);
                    errors = rest._errors;
                    context.Response.StatusCode = (int)rest._code;
                    break;
                case Exception e:
                    logger.LogError(ex, GlobalConstants.SERVER_ERROR);
                    errors = string.IsNullOrWhiteSpace(e.Message) ? "ERROR" : e.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            if (errors != null)
            {
                var response = JsonSerializer.Serialize(new { errors });
                await context.Response.WriteAsync(response);
            }
        }
    }
}