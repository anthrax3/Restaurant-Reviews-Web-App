
namespace MvcApplication2.Migrations
{
    using MvcApplication2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication2.Models.MvcApplication2Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcApplication2.Models.MvcApplication2Db context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabation's", Country = "USA", City = "Baltimore" },
                new Restaurant { Name = "Camino's", Country = "USA", City = "Georgia" },
                new Restaurant { Name = "Papa Jones", Country = "USA", City = "Cincinaty" },
                new Restaurant
                {
                    Name = "Smaka",
                    Country = "Sweden",
                    City = "Gothenburg",
                    Reviews = new List<RestaurnatReview> { new RestaurnatReview { Rating = 6, Body = "Great food", ReviewerName = "Scott" }},
                    RestaurantImage="~/Images2/abbbb.png"
                }
                );
            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }

            SeedMembership();
        }

        private void SeedMembership()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId",
                  "UserName", autoCreateTables: true);

            }
            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }

            if (membership.GetUser("sallen", false) == null)
            {
                membership.CreateUserAndAccount("sallen", "imalittleteapot");
            }

            if (!roles.GetRolesForUser("sallen").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "sallen" }, new[] { "Admin" });
            }
        }
    }
}
