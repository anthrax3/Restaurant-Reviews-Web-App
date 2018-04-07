using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class MvcApplication2Db : DbContext
    {
        public MvcApplication2Db()
        {

        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurnatReview> Reviews { get; set; }
    }
}