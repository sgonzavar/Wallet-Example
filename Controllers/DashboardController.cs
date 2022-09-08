using Microsoft.AspNetCore.Mvc;

namespace Wallet_Example.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
