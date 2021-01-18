using ID.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ID.Controllers
{
    public class Registration : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Index(string nikname, string mail)
        {
            User user = new User
            {
                Name = nikname,
                Mail = mail,
            };

        }

    }
}
