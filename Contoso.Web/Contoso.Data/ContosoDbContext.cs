using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext
    {
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
