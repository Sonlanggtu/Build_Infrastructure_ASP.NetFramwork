namespace Tier.Repository.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tier.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Tier.Repository.DataSoure_DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Tier.Repository.DataSoure_DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSoure_DbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new DataSoure_DbContext()));


            //var user = new ApplicationUser()
            //{
            //    UserName = "Sonlanggtu",
            //    Email = "Sonlanggtu@gmail.com",
            //    EmailConfirmed = true,
            //    Birthday = DateTime.Now,
            //    FullName = "Đàm Ngọc Sơn",
            //    Address = "Hưng Yên"

            //};
            //manager.Create(user, "abc@1234");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("Sonlanggtu@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
