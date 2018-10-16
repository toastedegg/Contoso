using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository
    {
        private ContosoDbContext db;
        public List<Department> GetAllDepartments()
        {
            return db.Departments.ToList();
        }

        public Department GetDepartmentById(int Id)
        {

            return db.Departments.FirstOrDefault(d => d.Id == Id);
        }

        public void AddDepartment(Department department)
        {


        }
        public void UpdateDepartment(Department department)
        {


        }

        public void DeleteDepartment(int Id)
        {

        }
    }
}
