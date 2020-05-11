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
           
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();
            
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }
            // 18. Function Imports

            // Complex data types : Entity Frame use these to return data from database
            // It become useful when we have to retrieve data from multiple tables or we want a subset of a data from large table
        }
    }
}
