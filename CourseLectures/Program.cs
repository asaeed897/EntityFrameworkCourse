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

            var course = context.Courses.Single(c => c.Id == 4);
              
            foreach (var tag in course.Tags)
            {
                Console.WriteLine(tag.Name);
            }

            // 56. Lazy Loading

            // by using virtual key words in property we enable LazyLoading
            // we can also enable and disable it in DbContext class configurations like I did in this project

            // Use it when loading an object graph is costly 
            // Use in desktop applications
            // Avoid in web applications 

        }
    }
}
