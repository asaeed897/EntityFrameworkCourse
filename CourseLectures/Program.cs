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

            // LINQ Extension Methods
            
            var tags = context.Courses
                .Where(c => c.Level == 1) // Restriction
                .OrderByDescending( c=> c.Name) // Ordering 
                .ThenByDescending( c=> c.Level)
                .SelectMany( c=> c.Tags) // Projection
                .Distinct(); // Set Operations

            foreach (var t in tags)
            {
                Console.WriteLine(t.Name);
            }

            // Grouping 
            var groups = context.Courses.GroupBy(c => c.Level);

            foreach (var group in groups)
            {
                Console.WriteLine("Key: " + group.Key);
                foreach (var course in group)
                {
                    Console.WriteLine("\t" +course.Name);
                }
            }

            // Joining 
            context.Courses.Join(context.Authors, // Inner Join
                c => c.AuthorId,
                a => a.Id,
                (course, author) => new
                    {
                        CourseName = course.Name,
                        AuthorName = author.Name
                    });

            context.Authors.GroupJoin(context.Courses, // Group Join
                a => a.Id,
                c => c.AuthorId,
                (author, courses) => new
                    {
                        Author = author.Name,
                        Courses = courses.Count()
                    });

            context.Authors.SelectMany(a => context.Courses, // Cross Join
                (author, course) => new
                {
                    AuthorName = author.Name,
                    CourseName = course.Name
                });

            // 49 LINQ Extension Methods

            // 
        }
    }
}
