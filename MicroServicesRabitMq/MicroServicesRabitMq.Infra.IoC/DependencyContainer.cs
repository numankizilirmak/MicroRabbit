using MicroServicesRabitMq.Domain.Core.Bus;
using MicroServicesRabitMq.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServicesRabitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabitMqBus>();
        }
    }
}
