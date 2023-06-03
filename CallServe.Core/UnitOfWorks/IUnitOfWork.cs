using CallServe.Core.EntityRepositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallServe.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }

        Task CommitAsync();
        void Commit();
    }
}
