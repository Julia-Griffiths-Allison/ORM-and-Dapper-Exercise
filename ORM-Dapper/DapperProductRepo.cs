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
    internal class DapperProductRepo
    {
        private readonly IDbConnection _connection;

        public DapperProductRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("Select * From Products;");
        }
        void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("Insert Into Products (Name), (Price), (CategoryID) Values (@name), (@price), (@id)",
                new { name = name, price = price, id = categoryID });
        }
    }
}
