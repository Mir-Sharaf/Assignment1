using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET /home/RsvpForm
        public IActionResult RsvpForm()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(CompetitionInvite invite)
        {
            // Check which button was pressed
            var button = Request.Form["submitButton"].ToString();

            switch (button)
            {
                case "Accept Invitation":
                    invite.WillAttend = true;
                    break;
                case "Send Regrets":
                    invite.WillAttend = false;
                    break;
            }

            return RedirectToAction("Thanks", invite);
        }

        public ActionResult Thanks(CompetitionInvite invite)
        {
            return View(invite);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}