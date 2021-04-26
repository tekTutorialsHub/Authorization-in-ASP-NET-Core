using Microsoft.AspNetCore.Authorization;

namespace AuthzExample.Authorization
{
    public class IsAllowedToManageProductRequirement : IAuthorizationRequirement
    {
    }
}
