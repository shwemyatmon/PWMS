using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager){
            if(!userManager.Users.Any()) {
                var user = new AppUser {
                    DisplayName = "Bobo",
                    Email = "bobo@test.com",
                    UserName = "bobo@test.com"
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}