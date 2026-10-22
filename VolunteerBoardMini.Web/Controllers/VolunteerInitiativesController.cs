using Microsoft.AspNetCore.Mvc;

namespace VolunteerBoardMini.Web.Controllers
{
    public class VolunteerInitiativesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
