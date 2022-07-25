using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Entities.Interfaces
{
    // podemos ver multiples operaciones y esas operaciones la salvamos todos o nada
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
