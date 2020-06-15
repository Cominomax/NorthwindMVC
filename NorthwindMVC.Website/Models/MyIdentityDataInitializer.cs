using Microsoft.AspNetCore.Identity;

namespace NorthwindMVC.Website.Models
{
    public static class IdentityDataInitializer
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("user1").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "user1",
                    Email = "user1@localhost"
                };

                IdentityResult result = userManager.CreateAsync(user, "Azerty18!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "NormalUser").Wait();
                }
            }


            if (userManager.FindByNameAsync("user2").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "user2",
                    Email = "user2@localhost"
                };

                IdentityResult result = userManager.CreateAsync(user, "Azerty18!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,"Administrator").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("NormalUser").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "NormalUser"
                };
                _ = roleManager.CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Administrator"
                };
                _ = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
