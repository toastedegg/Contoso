using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;

namespace Contoso.Service
{
    class DepartmentService : IDepartmentService
    {
        private DepartmentRepository departmentRepository;
        public List<Department> GetAllDepartments()
        {
            return departmentRepository.GetAllDepartments();
        }
        public Department GetDepartmentById(int Id)
        {
            return departmentRepository.GetDepartmentById(Id);
        }

    }

    interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int Id);
    }
}
