using CallServe.Core.Entities;
using CallServe.Core.Repositories.Contracts;
using CallServe.Core.UnitOfWorks;
using CallServe.Service.Service;
using CallServe.Service.Services.EntityServices.Contracts;

namespace CallServe.Service.Services.EntityServices
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
            
        }
    }
}
