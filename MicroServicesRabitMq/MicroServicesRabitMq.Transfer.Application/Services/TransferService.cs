using MicroServicesRabitMq.Domain.Core.Bus;
using MicroServicesRabitMq.Transfer.Application.Interfaces;
using MicroServicesRabitMq.Transfer.Domain.Interfaces;
using MicroServicesRabitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Transfer.Application.Services
{
    public class TransferService: ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;


        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }
        
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        
    }
}
