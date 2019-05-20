using Microsoft.AspNetCore.Mvc;

namespace TaskUser.Controllers
{
    public class ErrorController : Controller
    {
        // GET
        [Route("Error/401")]
        public IActionResult Error401()
        {
            return View();
        }

    }
}