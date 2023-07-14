using Microsoft.AspNetCore.Mvc;

namespace ButonStore.Controllers
{
    [Route("ButonStore")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Scaffold-DbContext "Host=localhost;Database=ButonStore;Username=postgres;Password=Yatra" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir DbEntityClasses -force
            return new JsonResult("Welcome to ButonStore API");
        }
    }
}
