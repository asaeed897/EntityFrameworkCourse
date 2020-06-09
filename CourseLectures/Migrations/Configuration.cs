using System.Collections.ObjectModel;

namespace CourseLectures.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseLectures.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseLectures.PlutoContext context)
        {
            context.Authors.AddOrUpdate( a => a.Name,
                new Author
                {
                    Name= "Author 1",
                    Courses= new Collection<Course>()
                    {
                        new Course(){ Name= "Programing Fundamentals"}
                    }
                });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
