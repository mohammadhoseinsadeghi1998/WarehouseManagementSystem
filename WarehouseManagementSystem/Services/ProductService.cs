using WarehouseManagementSystem.DataAccess;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Services
{
    internal class ProductService
    {
        public List<Product> GetProductList()
        {
            using (AppDbContext _Contex = new AppDbContext())
            {
                return _Contex.Products.ToList();
            }
        }
    }
}
