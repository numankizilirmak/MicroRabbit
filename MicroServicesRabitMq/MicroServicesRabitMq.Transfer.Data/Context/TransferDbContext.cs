using MicroServicesRabitMq.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServicesRabitMq.Transfer.Data.Context
{
    public class TransferDbContext:DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
