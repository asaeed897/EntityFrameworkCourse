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

            var courses = context.Courses.Include(c => c.Author).ToList();
              
            foreach (var course in courses)
            {
                Console.WriteLine("{0} by {1}", course.Name, course.Author.Name);
            }

            // 58 Eager Loading
            // Its opposite of lazy loading...

            // For single properties
            // context.Courses.Include(c => c.Author.Address);

            // For collection properties
            // context.Courses.Include(a => a.Tags.Select(t => t.Moderator))

            // Note: When you use too many include then your query become more and more complex
            // which is not good practice.

        } 
    }
}
