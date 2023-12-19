using Microsoft.AspNetCore.Mvc;

namespace Resort_Demo_Project.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        public IActionResult IndexAdmin()
        {
            return View();
        }
    }
}
