using FitnessApiClient.Context;
using Microsoft.EntityFrameworkCore;

namespace FitnessApiClient
{
    public class DbClient
    {
        private static readonly MyDbContext _context;

        static DbClient()
        {
            _context = new MyDbContext();
        }

        public static async Task<List<T>> GetTable<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
