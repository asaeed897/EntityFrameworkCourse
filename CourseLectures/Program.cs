using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLectures
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // LINQ Extension Methods which are not supported by LINQ Syntax
            
            // Partitioning
            var courses = context.Courses.Skip(10).Take(10);

            // Element Operators
            context.Courses.OrderBy(c => c.Level)
                .FirstOrDefault( c => c.FullPrice > 100); // Last method not supported in Sql

            context.Courses.SingleOrDefault(c => c.Id == 1);

            // Quantifying 
            var allAbove10Dollars = context.Courses.All(c => c.FullPrice > 10;
            var anyCourseInLevel1 = context.Courses.Any(c => c.Level == 1);
            
            // Aggregating
            var count = context.Courses.Where( c => c.Level == 1).Count();
            context.Courses.Max(c => c.FullPrice);
            context.Courses.Min(c => c.FullPrice);
            context.Courses.Average(c => c.FullPrice);

            // 50 LINQ Extension Methods Additional Methods

        }
    }
}
