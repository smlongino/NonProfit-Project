using Microsoft.AspNetCore.Mvc;





namespace NonProfitApp.Controllers
{

    public class TestController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
