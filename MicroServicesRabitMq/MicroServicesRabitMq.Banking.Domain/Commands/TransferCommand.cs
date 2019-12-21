using MicroServicesRabitMq.Domain.Core.Commands;


namespace MicroServicesRabitMq.Banking.Domain.Commands
{
    public class TransferCommand:Command
    {
        public int FromAccount { get; protected set; }
        public int ToAccount { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
