using FitnessApiClient.Api;
using FitnessApiClient.Context;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FitnessApiClient
{
    public class AdminDbClient : DbClient
    {
        private new readonly MyDbContext _context;

        public AdminDbClient(MyDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> AddEntity<T>(T entity) where T : class
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        public async Task<int> UpdateEntity<T>(int id, T updatedEntity) where T : class
        {
            try
            {
                var existingEntity = await _context.Set<T>().FindAsync(id);
                if (existingEntity == null)
                {
                    return -1;
                }
                _context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

    }
}