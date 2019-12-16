using MicroServicesRabitMq.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
