using Shared;

namespace Backend.MiddleWare
{
    public class AdminPassKeyMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly PassKeyVerifier _passKeyVerifier;

        public AdminPassKeyMiddleWare(RequestDelegate next, PassKeyVerifier passKeyVerifier)
        {
            _next = next;
            _passKeyVerifier = passKeyVerifier;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Items.ContainsKey("Admin"))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("UNAUTHORIZED: \"Admin\" property should not exist, remove it and try again. ");
                return;
            }
            if (context.Request.Headers.TryGetValue("AdminPassKey", out var passKey))
            {
                bool isAdmin = _passKeyVerifier.VerifyAdminPassKey(passKey);
                context.Items["Admin"] = isAdmin;
            }
            else
            {
                context.Items["Admin"] = false;
            }

            await _next(context);
        }
    }
}
