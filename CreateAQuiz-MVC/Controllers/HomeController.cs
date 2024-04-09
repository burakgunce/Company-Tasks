using CreateAQuiz_MVC.Context;
using CreateAQuiz_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CreateAQuiz_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreateAQuizDb _createAQuizDb;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(CreateAQuizDb createAQuizDb, UserManager<AppUser> userManager)
        {
            _createAQuizDb = createAQuizDb;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}