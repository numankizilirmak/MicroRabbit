using MicroServicesRabitMq.Banking.Application.Interfaces;
using MicroServicesRabitMq.Banking.Application.Models;
using MicroServicesRabitMq.Banking.Domain.Commands;
using MicroServicesRabitMq.Banking.Domain.Interfaces;
using MicroServicesRabitMq.Banking.Domain.Models;
using MicroServicesRabitMq.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;


        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount, accountTransfer.Amount);
            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
