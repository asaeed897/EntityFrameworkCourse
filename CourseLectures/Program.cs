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
                where c.Author.Id == 1
                orderby c.Level descending , c.Name
                select new { Name= c.Name, Author = c.Author};
            
            foreach (var course in query)
            {
                Console.WriteLine(course.Name);
            }

            // Grouping
            var query2 =
                from c in context.Courses
                group c by c.Level
                into g
                select g;

            foreach (var group in query2)
            {
                Console.WriteLine( "{0} ({1})", group.Key, group.Count());

            }

            // Joining    1: Inner Join   2: Group Join   3: Cross Join
            var query3 =  
                from c in context.Courses
                // So we can use Inner join like this when we don't have navigation property 
                join a in context.Authors on c.AuthorId equals a.Id
                select new {CourseName = c.Name, AuthorName = a.Name};

            var query4 = // group join example
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new {AuthorName = a.Name, Courses = g.Count()};

            foreach (var x in query4)
            {
                Console.WriteLine("{0}  ({1})", x.AuthorName, x.Courses);
            }

            var query5 = // Cross Join Example
                from a in context.Authors
                from c in context.Courses
                select new {AuthorName = a.Name, CourseName = c.Name};

            foreach (var x in query5)
            {
                Console.WriteLine("{0}  ({1})", x.AuthorName, x.CourseName);

            }

            // 48 LINQ Syntax

            // LINQ is usually used for simple and short queries 
            // but when we have complex queries then we have to write sql queries or stored procedures
        }
    }
}
