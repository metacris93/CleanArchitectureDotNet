using Shopping.Entities.Interfaces;
using Shopping.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ShoppingContext Context;
        public UnitOfWork(ShoppingContext context)
        {
            Context = context;
        }
        public Task<int> SaveChanges()
        {
            try
            {
                return Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(-1);
        }
    }
}
