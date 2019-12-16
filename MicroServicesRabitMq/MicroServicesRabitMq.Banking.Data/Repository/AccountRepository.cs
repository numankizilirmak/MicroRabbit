using MicroServicesRabitMq.Banking.Data.Context;
using MicroServicesRabitMq.Banking.Domain.Interfaces;
using MicroServicesRabitMq.Banking.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
