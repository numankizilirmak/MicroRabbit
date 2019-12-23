using MicroServicesRabitMq.Domain.Core.Bus;
using MicroServicesRabitMq.Transfer.Domain.Events;
using MicroServicesRabitMq.Transfer.Domain.Interfaces;
using MicroServicesRabitMq.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace MicroServicesRabitMq.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog { Amount = @event.Amount,
                FromAccount = @event.FromAccount,
                ToAccount=@event.ToAccount
            }) ;
            return Task.CompletedTask;
        }
    }
}
