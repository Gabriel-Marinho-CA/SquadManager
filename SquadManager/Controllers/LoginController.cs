using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            return View("index",user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "email enviado";
            return View("index", user);
        }
    }
}
