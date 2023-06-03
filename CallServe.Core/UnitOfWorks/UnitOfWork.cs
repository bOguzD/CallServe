namespace CallServe.Core.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CallServeContext _context;

        public UnitOfWork(CallServeContext context)
        {
            _context = context;
        }

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
