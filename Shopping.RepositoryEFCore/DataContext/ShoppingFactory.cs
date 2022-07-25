using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.RepositoryEFCore.DataContext
{
    // Esto se lleva a cabo en tiempo de diseño
    class ShoppingFactory : IDesignTimeDbContextFactory<ShoppingContext>
    {
        public ShoppingContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShoppingContext>();
            optionsBuilder.UseSqlServer("Server= DESKTOP-S83CUC7; Database= Shopping; Integrated Security=True;");
            return new ShoppingContext(optionsBuilder.Options);
        }
    }
}
