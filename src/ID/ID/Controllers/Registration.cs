using ID.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ID.Controllers
{
    public class Registration : Controller
    {
        private ApplicationContext db;
        public Registration(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await db.UserReg.ToListAsync());
        }
        [HttpGet]
        public IActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reg(string nikname, string mail)
        {
            User user = new User
            {
                Name = nikname,
                Mail = mail,
            };
            db.UserReg.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
