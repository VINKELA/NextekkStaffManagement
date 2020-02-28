using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using NextekkStaffManager.Models;


// dotnet aspnet-codegenerator razorpage -m Contact -dc aspnetnextekkstaffmanagement9EDC075A4DE04C2783DAABD9B3999E34Context -outDir Pages\Contacts --referenceScriptLibraries
namespace NextekkStaffManager.Data
{
    public static class SeedData
    {
       
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context(
                serviceProvider.GetRequiredService<DbContextOptions<aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context>>()))
            {
                // For sample purposes seed both with the same password.
                // Password is set with the following:
                // dotnet user-secrets set SeedUserPW <pw>
                // The admin user can do anything
                
                //var adminID = await EnsureUser(serviceProvider, testUserPw, "admin@nextekk.com");
                await EnsureRole(serviceProvider);
                // allowed user can create and edit contacts that they create
                //var managerID = await EnsureUser(serviceProvider, testUserPw, "manager@contoso.com");
                //await EnsureRole(serviceProvider, managerID, UserRole.StaffRole);

                //SeedDB(context, adminID);
            }
        }

        private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                                                    string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new IdentityUser {
                    UserName = UserName,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(user, testUserPw);
            }

            if (user == null)
            {
                throw new Exception("The password is probably not strong enough!");
            }

            return user.Id;
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider)
        {
            IdentityResult IR = null;
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (roleManager == null)
            {
                throw new Exception("roleManager null");
            }

            if (!await roleManager.RoleExistsAsync(Constants.Admin))
            {
                IR = await roleManager.CreateAsync(new IdentityRole(Constants.Admin));
            }

            if (!await roleManager.RoleExistsAsync(Constants.Staff))
            {
                var IVR = await roleManager.CreateAsync(new IdentityRole(Constants.Staff));
            }

            //var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            //var user = await userManager.FindByIdAsync(uid);

            //if(user == null)
            //{
                //throw new Exception("The testUserPw password was probably not strong enough!");
            //}
            
            //IR = await userManager.AddToRoleAsync(user, Constants.Admin);

            return IR;
        }
        
    }
}