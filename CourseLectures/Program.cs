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

            var courses = context.Courses
                .ToList().Where(c => c.IsBeginnerCourse == true)
                .OrderBy(c => c.Name);

            foreach (var c in courses)
            {
                Console.WriteLine(c.Name);
            }

            // 51 Deferred Execution

            // Queries are not executed at the time you create them.

            // Query executed when
            // Iterating over it
            // Calling ToList, ToArray, ToDictionary
            // or Calling First, Last, Single, Count, Max, Min, Average

        }
    }
}
