using Microsoft.AspNetCore.Mvc;

namespace ButonStore.Controllers
{
    [Route("ButonStore")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new JsonResult("Welcome to ButonStore API");
        }
    }
}
