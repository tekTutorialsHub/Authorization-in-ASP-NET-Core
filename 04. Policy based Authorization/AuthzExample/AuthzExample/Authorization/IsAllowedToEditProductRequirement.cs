using Microsoft.AspNetCore.Authorization;

namespace AuthzExample.Authorization
{
    public class IsAccountEnabledRequirement : IAuthorizationRequirement
    {
    }
}