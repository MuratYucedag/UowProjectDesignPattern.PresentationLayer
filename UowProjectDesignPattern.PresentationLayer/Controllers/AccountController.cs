using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UowProjectDesignPattern.BusinessLayer.Abstract;
using UowProjectDesignPattern.DataAccessLayer.Concrete;
using UowProjectDesignPattern.EntityLayer.Concrete;
using UowProjectDesignPattern.PresentationLayer.Models;

namespace UowProjectDesignPattern.PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProcessViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);

            value1.TotalBalance -= p.Amount;
            value2.TotalBalance += p.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };
            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
