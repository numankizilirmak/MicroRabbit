using MicroServicesRabitMq.Banking.Application.Interfaces;
using MicroServicesRabitMq.Banking.Application.Services;
using MicroServicesRabitMq.Banking.Data.Context;
using MicroServicesRabitMq.Banking.Data.Repository;
using MicroServicesRabitMq.Banking.Domain.Interfaces;
using MicroServicesRabitMq.Domain.Core.Bus;
using MicroServicesRabitMq.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using MicroServicesRabitMq.Banking.Domain.Commands;
using MicroServicesRabitMq.Banking.Domain.CommandHandlers;
using MicroServicesRabitMq.Transfer.Application.Interfaces;
using MicroServicesRabitMq.Transfer.Application.Services;
using MicroServicesRabitMq.Transfer.Domain.Interfaces;
using MicroServicesRabitMq.Transfer.Data.Repository;
using MicroServicesRabitMq.Transfer.Data.Context;
using MicroServicesRabitMq.Banking.Domain.Events;
using MicroServicesRabitMq.Transfer.Domain.EventHandlers;

namespace MicroServicesRabitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IEventBus, RabitMqBus>(x=>
            {
                var scopeFactory = x.GetRequiredService<IServiceScopeFactory>();
                return new RabitMqBus(x.GetService<IMediator>(), scopeFactory);
            });
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>,TransferCommandHandler>();
            services.AddTransient<BankingDbContext>();

            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<TransferDbContext>();
            services.AddTransient<TransferEventHandler>();
            services.AddTransient<IEventHandler<Transfer.Domain.Events.TransferCreatedEvent>, TransferEventHandler>();

        }
    }
}
