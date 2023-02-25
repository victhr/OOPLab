using Microsoft.AspNetCore.Authorization;
using WWWebAuth.Security.Requirements;

namespace WWWebAuth.Security.Handlers
{
    public class RoleValidationHandler : AuthorizationHandler<RoleValidationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleValidationRequirement requirement)
        {
            context.Succeed(requirement);
        
            return Task.CompletedTask;
        }
    }
}
