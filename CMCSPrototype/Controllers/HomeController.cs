using Microsoft.AspNetCore.Mvc;

namespace CMCSPrototype.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult LecturerDashboard() => View();
        public IActionResult SubmitClaim() => View();
        public IActionResult CoordinatorDashboard() => View();
        public IActionResult ManagerDashboard() => View();
    }
}

