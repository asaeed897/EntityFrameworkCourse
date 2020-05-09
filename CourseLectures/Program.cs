using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLectures
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFisrtDemoEntities1();
            var post = new C0001_Post_Table()
            {
                Body = "Body",
                DataPublished = DateTime.Now,
                Title = "Title",
                PostID = 1
            };
            context.C0001_Post_Table.Add(post);
            context.SaveChanges();
            // 7. Database-First Workflow
        }
    }
}
