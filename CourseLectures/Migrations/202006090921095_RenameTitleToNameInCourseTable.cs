namespace CourseLectures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Name= Title");
            DropColumn("dbo.Courses", "Title");
            //RenameColumn("dbo.Courses", "Title", "Name"); This is another way to doing above
            // we are doing this to saving our content in title column because if we drop this without saving then we
            // can lose our entire title data. so be careful and also change DOWN method we u change UP method. 
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title= Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
