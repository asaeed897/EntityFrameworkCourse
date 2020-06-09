namespace CourseLectures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAuthor_IdColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Author_Id", c => c.Int());
        }
    }
}
