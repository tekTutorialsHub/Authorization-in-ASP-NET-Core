using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace AuthzExample.Authorization
{
    public class IsEmployeeHandler : AuthorizationHandler<IsAllowedToManageProductRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       IsAllowedToManageProductRequirement requirement)
        {
            if (context.User.HasClaim(f => f.Type == "Employee"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
