using MicroServicesRabitMq.Banking.Application.Models;
using MicroServicesRabitMq.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabitMq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
