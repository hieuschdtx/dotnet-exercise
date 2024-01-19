using Microsoft.AspNetCore.Identity;

namespace Jwt_authentication.API.Entites
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
