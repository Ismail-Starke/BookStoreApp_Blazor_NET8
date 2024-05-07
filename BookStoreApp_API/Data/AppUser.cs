using Microsoft.AspNetCore.Identity;

namespace BookStoreApp_API.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
