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

namespace MicroServicesRabitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabitMqBus>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>,TransferCommandHandler>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
