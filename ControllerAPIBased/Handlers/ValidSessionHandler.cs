

using ControllerAPIBased.Requirements;
using Microsoft.AspNetCore.Authorization;

namespace ControllerAPIBased.Handlers
{
    public class ValidSessionHandler : AuthorizationHandler<ValidSessionAuthorization>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ValidSessionAuthorization requirement)
        {
            context.Succeed(requirement);
            //context.Fail();
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }
    }
}
