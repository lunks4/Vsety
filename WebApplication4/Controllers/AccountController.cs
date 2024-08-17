using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.Db;
using System.Diagnostics;
using WebApplication4.Models.ViewModel;

namespace WebApplication4.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext _context;

        public AccountController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(model);
                //await _context.SaveChangesAsync();
                User user = new User() {Mail=model.Login, Password=model.Password};
                PersonViewModel model1 = new PersonViewModel() {User = user};
                _context.Add(user);
                //await _context.SaveChangesAsync();
                return RedirectToAction("Person", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Person()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Person(PersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(model);
                //await _context.SaveChangesAsync();
                model.User.Person = model.Person;
                _context.Add(model.User);
                _context.Add(model.Person);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
