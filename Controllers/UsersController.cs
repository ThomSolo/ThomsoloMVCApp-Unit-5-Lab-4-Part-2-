using Microsoft.AspNetCore.Mvc;
using ThomsoloMVCApp.Models;

namespace ThomsoloMVCApp.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult YKView()
        {
            return View(uc.YkumarTables.ToList());
        }
    }
}
