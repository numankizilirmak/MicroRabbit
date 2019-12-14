using MicroServicesRabitMq.Domain.Core.Events;
using System;

namespace MicroServicesRabitMq.Domain.Core.Commands
{
   public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
