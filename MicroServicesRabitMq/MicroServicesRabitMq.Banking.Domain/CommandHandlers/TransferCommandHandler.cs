using MediatR;
using MicroServicesRabitMq.Banking.Domain.Commands;
using MicroServicesRabitMq.Banking.Domain.Events;
using MicroServicesRabitMq.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServicesRabitMq.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(request.FromAccount,request.ToAccount,request.Amount));
            return Task.FromResult(true);
        }
    }
}
