using MicroServicesRabitMq.Transfer.Data.Context;
using MicroServicesRabitMq.Transfer.Domain.Interfaces;
using MicroServicesRabitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        TransferDbContext _context;        
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
        public void Add(TransferLog transferLog)
        {
            _context.Add(transferLog);
            _context.SaveChanges();
        }
    }
}
