using System.Collections.Generic;
using MicroServicesRabitMq.Transfer.Application.Interfaces;
using MicroServicesRabitMq.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroServicesRabitMq.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        private readonly ILogger<TransferController> _logger;

        public TransferController(ILogger<TransferController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public IEnumerable<TransferLog> Get()
        {
           return _transferService.GetTransferLogs();
        }
    }
}
