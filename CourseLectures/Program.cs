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

            

            // 52 IQueryable Explained

            // IEnumerable are those types over we can use foreach loop: string, array, list, dictionary
            // IQueryable derived from IEnumerable
            // IQueryable has expression objects in arguments which allow us to chain our queries
            // and it execute them when we iterate 
        }
    }
}
