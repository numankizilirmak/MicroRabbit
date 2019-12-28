using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroServicesRabitMq.WebApp.Models;
using MicroServicesRabitMq.WebApp.Services;
using MicroServicesRabitMq.WebApp.Models.DTO;

namespace MicroServicesRabitMq.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransferService _transferService;

        public HomeController(ILogger<HomeController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel transferViewModel)
        {
            var transferDto = new TransferDto()
            {
                Amount=transferViewModel.TransferAmount,
                FromAccount=transferViewModel.FromAccount,
                ToAccount=transferViewModel.ToAccount
            };
            await _transferService.Transfer(transferDto);
            return View("Index");
        }
    }
}
