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

            // Cascade Delete
            // var course = context.Courses.Find(4); // Single(c => c.Id == 4)
            // context.Courses.Remove(course);

            // Without Cascade Delete
            var author = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
            context.Courses.RemoveRange(author.Courses);
            context.Authors.Remove(author);

            context.SaveChanges();
            // 66. Removing Objects

            // Prefer logical deletes to Physical deletes.
            // author.IsDeleted = true; for logical delete and false for undo

        } 
    }
}
