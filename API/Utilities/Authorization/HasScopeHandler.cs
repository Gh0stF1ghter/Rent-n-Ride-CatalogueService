using Microsoft.AspNetCore.Authorization;

namespace API.Utilities.Authorization;

public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        HasScopeRequirement requirement
        )
    {
        if (!context.User.HasClaim(c => c.Type == "scope" && c.Issuer == requirement.Issuer))
        {
            // Split the scopes string into an array
            var scopes = context.User
              .FindAll(c => c.Type == "scope" && c.Issuer == requirement.Issuer);

            // Succeed if the scope array contains the required scope
            if (scopes.Any(s => s.Value == requirement.Scope))
                context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }
}