using System.Web.Mvc;

namespace SmallestMvc
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}