using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabitMq.Banking.Domain.Commands
{
    public class CreateTransferCommand:TransferCommand
    {
        public CreateTransferCommand(int from,int to,decimal amount)
        {
            FromAccount = from;
            ToAccount = to;
            Amount = amount;
        }
    }
}
