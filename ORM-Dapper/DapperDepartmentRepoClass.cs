using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal class DapperDepartmentRepoClass
    {
        private readonly IDbConnection _connection;
        public DapperDepartmentRepoClass(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Departments> GetAllDepartments()
        {
            return _connection.Query<Departments>("Select * From Departments;");
        }
        public void InsertDepartments(string departmentName)
        {
            _connection.Execute("Insert Into Departments (Name) Values (@name)",
                new { name = departmentName });
        }
        public void UpdateDepartment(int id, string updatedDepartmentName)
        {
            _connection.Execute("Update Departments Set Name = @name Where DepartmentID = @ID",
                new { name = updatedDepartmentName, ID = id });
        }
        public void DeleteDepartment(int id)
        {
            _connection.Execute("Delete From Departments Where DepartmentID = @id",
                new { id = id });
        }
    }
}
