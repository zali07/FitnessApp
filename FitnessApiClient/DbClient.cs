using FitnessApiClient.Context;
using Microsoft.EntityFrameworkCore;

namespace FitnessApiClient
{
    public class DbClient : IDisposable
    {
        protected readonly MyDbContext _context;

        public DbClient(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<T>> GetTable<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
