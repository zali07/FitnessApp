using FitnessApiClient.Api;
using FitnessApiClient.Context;

namespace FitnessApiClient
{
    public class AdminDbClient : DbClient
    {
        private new readonly MyDbContext _context;

        public AdminDbClient(MyDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> AddTicketType(TicketTypes pTicketType)
        {
            try
            {
                _context.TicketTypes.Add(pTicketType);
                await _context.SaveChangesAsync();
                return 1;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
    }
}