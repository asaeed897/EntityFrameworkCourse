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

            // LINQ Syntax
            var query =
                from c in context.Courses
                where c.Name.Contains("C#")
                orderby c.Name
                select c;
            
            foreach (var course in query)
            {
                Console.WriteLine(course.Name);
            }

            // Extension Methods  Preferred Method of querying data
            var courses = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }

            // 47 LINQ in Action

            // LINQ is usually used for simple and short queries 
            // but when we have complex queries then we have to write sql queries or stored procedures
        }
    }
}
