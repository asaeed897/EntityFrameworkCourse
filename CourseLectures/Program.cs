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

            // Add an Object
            context.Authors.Add(new Author() {Name = "New Author"});

            // Update an object
            var author = context.Authors.Find(7);
            author.Name = "Updated";

            // Removing an Object
            var another = context.Authors.Find(7);
            context.Authors.Remove(another);

            var entries = context.ChangeTracker.Entries();

            foreach (var entry in entries)
            {
               // entry.Reload(); // Useful method 

                Console.WriteLine(entry.State);
            }

            // 67. Working with Change Tracker

        } 
    }
}
