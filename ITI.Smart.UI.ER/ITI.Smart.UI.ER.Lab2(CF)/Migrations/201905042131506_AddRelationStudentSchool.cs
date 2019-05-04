namespace ITI.Smart.UI.ER.Lab2_CF_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationStudentSchool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Fk_SchoolId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "School_Id", c => c.Int());
            CreateIndex("dbo.Students", "School_Id");
            AddForeignKey("dbo.Students", "School_Id", "dbo.Schools", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropColumn("dbo.Students", "School_Id");
            DropColumn("dbo.Students", "Fk_SchoolId");
        }
    }
}
