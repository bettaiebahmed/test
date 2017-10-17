namespace Intranet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_push : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        idClassroom = c.Int(nullable: false, identity: true),
                        name_classroom = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idClassroom);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        idStudent = c.Int(nullable: false, identity: true),
                        name_student = c.String(unicode: false),
                        Classroom_idClassroom = c.Int(),
                    })
                .PrimaryKey(t => t.idStudent)
                .ForeignKey("dbo.Classrooms", t => t.Classroom_idClassroom)
                .Index(t => t.Classroom_idClassroom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Classroom_idClassroom", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "Classroom_idClassroom" });
            DropTable("dbo.Students");
            DropTable("dbo.Classrooms");
        }
    }
}
