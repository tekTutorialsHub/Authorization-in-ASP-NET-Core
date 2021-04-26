using AuthzExample.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthzExample.Authorization
{
    public class DocumentAuthorizationHandler : AuthorizationHandler<SameAuthorRequirement, Product>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                        SameAuthorRequirement requirement,
                                                        Product resource)
        {

            if (context.User.HasClaim(ClaimTypes.NameIdentifier, resource.CreatedUserID))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}