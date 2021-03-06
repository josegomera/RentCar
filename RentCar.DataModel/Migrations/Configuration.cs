namespace RentCar.DataModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentCar.DataModel.Context.RentCarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentCar.DataModel.Context.RentCarDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Users.Any())
            {
                context.Users.Add(new Entities.User
                {
                    UserName = "Admin",
                    Password = "Admin1234"
                });

                context.SaveChanges();
            }
        }
    }
}
