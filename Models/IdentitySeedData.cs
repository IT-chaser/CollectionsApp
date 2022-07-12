using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CollectionsApp.Data;

namespace CollectionsApp.Models {
    public static class IdentitySeedData {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";
        public static async void EnsurePopulated(IApplicationBuilder app) {
            CollectionsAppIdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<CollectionsAppIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null) {
                user = new IdentityUser("Admin");
                user.Email = "admin@email.com";
                user.PhoneNumber = "111-1234";
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}