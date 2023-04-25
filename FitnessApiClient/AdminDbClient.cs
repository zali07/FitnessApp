using FitnessApiClient.Api;
using FitnessApiClient.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApiClient
{
    public class AdminDbClient : DbClient
    {
        private new readonly MyDbContext _context;

        public AdminDbClient(MyDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddTicketType(TicketTypes pTicketType)
        {
            _context.TicketTypes.Add(pTicketType);
            await _context.SaveChangesAsync();
        }
    }
}
