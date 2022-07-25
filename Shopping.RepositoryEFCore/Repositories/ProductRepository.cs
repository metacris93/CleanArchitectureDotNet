using Shopping.Entities.Domain;
using Shopping.Entities.Interfaces;
using Shopping.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly ShoppingContext Context;
        public ProductRepository(ShoppingContext context)
        {
            Context = context;
        }
        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Context.Products;
        }
    }
}
