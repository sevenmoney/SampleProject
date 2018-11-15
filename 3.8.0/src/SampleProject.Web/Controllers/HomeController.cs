using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Web.Controllers
{
    public class HomeController : SampleProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}