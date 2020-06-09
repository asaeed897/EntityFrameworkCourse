namespace CourseLectures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFluentAPIToCourseTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            RenameColumn(table: "dbo.CourseTags", name: "Course_Id", newName: "CourseId");
            RenameColumn(table: "dbo.CourseTags", name: "Tag_Id", newName: "TagId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Course_Id", newName: "IX_CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Tag_Id", newName: "IX_TagId");
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Covers", "Id", "dbo.Courses");
            DropIndex("dbo.Covers", new[] { "Id" });
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            DropColumn("dbo.Courses", "AuthorId");
            DropTable("dbo.Covers");
            RenameIndex(table: "dbo.CourseTags", name: "IX_TagId", newName: "IX_Tag_Id");
            RenameIndex(table: "dbo.CourseTags", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.CourseTags", name: "TagId", newName: "Tag_Id");
            RenameColumn(table: "dbo.CourseTags", name: "CourseId", newName: "Course_Id");
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}
