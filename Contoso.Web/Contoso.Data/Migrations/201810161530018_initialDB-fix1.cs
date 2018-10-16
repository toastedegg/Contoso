namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDBfix1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Budget = c.Long(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        RowVersion = c.String(nullable: false, maxLength: 20),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Grade = c.String(maxLength: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Credits = c.Short(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        MiddleName = c.String(maxLength: 20),
                        Email = c.String(maxLength: 40),
                        Phone = c.String(maxLength: 20),
                        AddressLine1 = c.String(nullable: false, maxLength: 20),
                        AddressLine2 = c.String(maxLength: 20),
                        UnitOrApartmentNumber = c.Byte(nullable: false),
                        City = c.String(nullable: false, maxLength: 20),
                        State = c.String(nullable: false, maxLength: 20),
                        ZipCode = c.String(nullable: false, maxLength: 10),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Salt = c.Boolean(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailAttempts = c.Int(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_Id, t.Course_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id, cascadeDelete: true)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 20),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.PersonRoles",
                c => new
                    {
                        Person_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_Id, t.Role_Id })
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Person_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 20),
                        Description = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 20),
                        UpdatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.PersonRoles", "Person_Id", "dbo.People");
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropForeignKey("dbo.InstructorCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Instructors", "Id", "dbo.People");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "Id", "dbo.People");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.PersonRoles", new[] { "Role_Id" });
            DropIndex("dbo.PersonRoles", new[] { "Person_Id" });
            DropIndex("dbo.InstructorCourses", new[] { "Course_Id" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_Id" });
            DropIndex("dbo.Instructors", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropTable("dbo.Roles");
            DropTable("dbo.PersonRoles");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.InstructorCourses");
            DropTable("dbo.Instructors");
            DropTable("dbo.People");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Departments");
        }
    }
}
