using Fliper.Data.ProClientHub.Data;
using Fliper.Models;
using Fliper.ViewModels.ProClientHub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fliper.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vm = new LandingPageViewModel
            {
                Projects = _context.Projects.ToList(),
                Clients = _context.Clients.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult SubmitContact(ContactForm form)
        {
            _context.ContactForms.Add(form);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Subscribe(string email)
        {
            _context.Subscriptions.Add(new Subscription { Email = email });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
