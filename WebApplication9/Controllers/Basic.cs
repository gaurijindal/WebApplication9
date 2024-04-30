using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers
{
    public class Basic : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("sample/message")]
        public IActionResult Message()
        {
            return View();
        }
    }
}
