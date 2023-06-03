using CallServe.Core.Entities;
using CallServe.Core.EntityRepositories.Contracts;
using CallServe.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallServe.Core.EntityRepositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CallServeContext context) : base(context)
        {
        }
    }
}
