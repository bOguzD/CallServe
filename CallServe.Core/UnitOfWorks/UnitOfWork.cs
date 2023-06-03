using CallServe.Core.EntityRepositories;
using CallServe.Core.EntityRepositories.Contracts;
using Microsoft.Extensions.Logging;

namespace CallServe.Core.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CallServeContext _context;
        private readonly ILogger _logger;
        private ProductRepository? _productRepository;

        public UnitOfWork(CallServeContext context, ILoggerFactory logger)
        {
            _context = context;
            _logger = logger.CreateLogger("logs");
        }

        public IProductRepository Product => _productRepository = _productRepository ?? new ProductRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
