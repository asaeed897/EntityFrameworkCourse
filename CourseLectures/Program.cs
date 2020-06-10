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

            // 72. Repository Pattern

            // Mediates between the domain and data mapping layers, acting like an
            // in-memory collection of domain objects.

            // Benefits

            // Minimizes duplicate query logic
            // Decouples your application from persistence framework
        } 
    }
}
