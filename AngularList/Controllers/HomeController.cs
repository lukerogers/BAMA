using System.Web.Mvc;

namespace AngularList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lists()
        {
            return PartialView();
        }

        public ActionResult List()
        {
            return PartialView();
        }
    }
}
