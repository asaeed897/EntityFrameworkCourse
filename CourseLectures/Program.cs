using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLectures
{
    public enum Level : byte
    {
         Beginner = 1,
         Intermediate = 2,
         Advanced = 3
    }
    class Program
    {
        static void Main(string[] args)
        {

            var course = new Course();
            course.Level = Level.Beginner; // 1
            // 19. Working with Enums

            // We can create Enum in data model or in any other place in project but then we have to
            // reference it.
        }
    }
}
