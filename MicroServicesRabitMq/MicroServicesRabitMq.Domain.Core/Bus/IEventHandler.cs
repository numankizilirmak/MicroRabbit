using MicroServicesRabitMq.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroServicesRabitMq.Domain.Core.Bus
{
   public interface IEventHandler<in TEvent>: IEventHandler where TEvent:Event
    {
        Task Handle(TEvent @event);
    }
    public interface IEventHandler
    {
     
    }
}
