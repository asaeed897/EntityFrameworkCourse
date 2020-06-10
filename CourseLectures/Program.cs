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
            
            // Two Approaches are common for adding object

            // 1. Using an existing object in context
            var authors = context.Authors.ToList();
            var author = context.Authors.Single(a => a.Id == 2);

            // there is 3rd approach also
            context.Authors.Attach(author); // but its not recommended

            var course = new Course
            {
                Name = "New Course 2",
                Description = "New Description",
                FullPrice = 19.95f,
                Level = 1,
                Author = author
               // , AuthorId = 1 // 2. Using foreign key properties
            };

            context.Courses.Add(course);

            context.SaveChanges();
            // 64. Adding Objects

        } 
    }
}
