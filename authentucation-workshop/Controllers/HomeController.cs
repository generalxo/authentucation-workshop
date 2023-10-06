using authentucation_workshop.Models;
using authentucation_workshop.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace authentucation_workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<UserModel> _userManager;

        public HomeController(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user is not null)
            {
                var viewModel = new IndexViewModel()
                {
                    Nickname = user.Nickname,
                };
                return View(viewModel);
            }
            else
            {
                return View();
            }
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
    }
}