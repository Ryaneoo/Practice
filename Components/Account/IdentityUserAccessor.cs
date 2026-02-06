using _2401377C.Data;
using Microsoft.AspNetCore.Identity;

namespace _2401377C.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<_2401377CUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<_2401377CUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
