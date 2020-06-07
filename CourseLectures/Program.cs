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
            // 20 and 21 . Exercise & Summary

            // 
        }
    }
}
