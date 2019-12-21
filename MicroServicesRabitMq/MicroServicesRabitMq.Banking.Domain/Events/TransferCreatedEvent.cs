using MicroServicesRabitMq.Domain.Core.Events;

namespace MicroServicesRabitMq.Banking.Domain.Events
{
   public class TransferCreatedEvent:Event
    {
        public int FromAccount { get; protected set; }
        public int ToAccount { get; protected set; }
        public decimal Amount { get; protected set; }

        public TransferCreatedEvent(int from,int to,decimal amount)
        {
            FromAccount = from;
            ToAccount = to;
            Amount = amount;
        }
    }

}
