using MicroServicesRabitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabitMq.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
