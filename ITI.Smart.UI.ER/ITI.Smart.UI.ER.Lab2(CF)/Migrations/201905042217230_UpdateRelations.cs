namespace ITI.Smart.UI.ER.Lab2_CF_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropColumn("dbo.Students", "Fk_SchoolId");
            RenameColumn(table: "dbo.Students", name: "School_Id", newName: "Fk_SchoolId");
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Students", "Fk_SchoolId", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Schools", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Students", "Fk_SchoolId");
            AddForeignKey("dbo.Students", "Fk_SchoolId", "dbo.Schools", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Fk_SchoolId", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "Fk_SchoolId" });
            AlterColumn("dbo.Schools", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AlterColumn("dbo.Students", "Fk_SchoolId", c => c.Int());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            RenameColumn(table: "dbo.Students", name: "Fk_SchoolId", newName: "School_Id");
            AddColumn("dbo.Students", "Fk_SchoolId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "School_Id");
            AddForeignKey("dbo.Students", "School_Id", "dbo.Schools", "Id");
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
        }
    }
}
