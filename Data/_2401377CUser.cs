using Microsoft.AspNetCore.Identity;

namespace _2401377C.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class _2401377CUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
