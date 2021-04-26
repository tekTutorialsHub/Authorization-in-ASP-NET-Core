using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace AuthzExample.Authorization
{
    public class IsAccountNotDisabledHandler : AuthorizationHandler<IsAccountEnabledRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       IsAccountEnabledRequirement requirement)
        {
            if (context.User.HasClaim(f => f.Type == "Disabled"))
            {
                context.Fail();
            }
            else
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}