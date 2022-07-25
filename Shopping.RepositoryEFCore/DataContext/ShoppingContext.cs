using Microsoft.EntityFrameworkCore;
using Shopping.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.RepositoryEFCore.DataContext
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
