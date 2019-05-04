namespace ITI.Smart.UI.ER.Lab2_CF_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationStudentContactInfo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
            DropPrimaryKey("dbo.ContactInfoes");
            DropPrimaryKey("dbo.CourseStudents");
            AlterColumn("dbo.ContactInfoes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ContactInfoes", "Id");
            AddPrimaryKey("dbo.CourseStudents", new[] { "Course_Id", "Student_Id" });
            CreateIndex("dbo.ContactInfoes", "Id");
            AddForeignKey("dbo.ContactInfoes", "Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactInfoes", "Id", "dbo.Students");
            DropIndex("dbo.ContactInfoes", new[] { "Id" });
            DropPrimaryKey("dbo.CourseStudents");
            DropPrimaryKey("dbo.ContactInfoes");
            AlterColumn("dbo.ContactInfoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CourseStudents", new[] { "Student_Id", "Course_Id" });
            AddPrimaryKey("dbo.ContactInfoes", "Id");
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
        }
    }
}
