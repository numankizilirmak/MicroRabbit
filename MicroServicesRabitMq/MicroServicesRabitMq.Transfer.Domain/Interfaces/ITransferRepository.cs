using MicroServicesRabitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();

        void Add(TransferLog transferLog);
    }
}
