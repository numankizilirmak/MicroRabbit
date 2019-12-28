using MicroServicesRabitMq.Banking.Application.Interfaces;
using MicroServicesRabitMq.Banking.Application.Models;
using MicroServicesRabitMq.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroServicesRabitMq.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/Banking")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
        [HttpPost]
        public ActionResult Post(AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
