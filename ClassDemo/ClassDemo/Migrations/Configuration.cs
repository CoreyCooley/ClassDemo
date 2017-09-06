using ClassDemo.Models;

namespace ClassDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClassDemo.Models.ApplicationDbContext";
        }

        protected override void Seed(ClassDemo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                s => s.IHateTylerId,
                new Student {  FirstName = "Tyler", LastName = "Blake", BirthDay = DateTime.Now.AddYears(-25), TotalCreditHours = 250},
                new Student {  FirstName = "Corey", LastName = "Cooley", BirthDay = DateTime.Now.AddYears(-27).AddDays(2).AddMonths(-5), TotalCreditHours = 108}
                );
        }
    }
}
