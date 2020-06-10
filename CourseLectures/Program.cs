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

            var author = context.Authors.Single(a=> a.Id== 5);

            // MSDN way
            context.Entry(author).Collection(a=> a.Courses).Load();  
            // bad thing is that we can use it with single elements like author
            // we can't use this with list of authors

            // Mosh way
            context.Courses.Where(c=> c.AuthorId == author.Id ).Load();    

            foreach (var course in author.Courses)
            {
                Console.WriteLine("{0}", course.Name);
            }

            // In Mosh way we can use list of authors and etc
            var authors = context.Authors.ToList();
            var authorIds = authors.Select(a => a.Id);

            context.Courses.Where(c=> authorIds.Contains(c.AuthorId) && c.FullPrice == 0).Load();

            // 59 Explicit Loading

            // It is same like eager loading but it have separate queries according to load
            // it also have multiple round-trips to load objects.



        } 
    }
}
