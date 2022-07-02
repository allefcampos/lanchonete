using Lanchonete.Models;
using Lanchonete.Repositories;
using Lanchonete.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lanchonete.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILancheRepository _lancheRepository;

        public HomeController(ILogger<HomeController> logger, ILancheRepository lancheRepository)
        {
            _logger = logger;
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeView = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeView);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
