using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal interface IDepartmentRepo
    {
        public IEnumerable<Departments> GetAllDepartments();
        public void InsertDepartments(string departmentName);
        public void UpdateDepartment(int id, string updatedDepartmentName);
        public void DeleteDepartment(int id);
    }
}
