using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLectures
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            // 8. Code-First Workflow

            // Resolved that issue that is because of older version of my windows powershell. I update my windows Powershell
            // and its work.
        }
    }
}
