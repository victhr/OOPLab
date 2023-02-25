using Microsoft.AspNetCore.Authorization;
using WWWebAuth.Security.Requirements;

namespace WWWebAuth.Security.Handlers
{
    public class ValidSessionHandler : AuthorizationHandler<ValidSessionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ValidSessionRequirement requirement)
        {
            if (context.User.HasClaim(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name" && c.Value != null))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
