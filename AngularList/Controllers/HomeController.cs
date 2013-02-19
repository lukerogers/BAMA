using System.Web.Mvc;
using BootstrapMvcSample.Controllers;

namespace AngularList.Controllers
{
    public class HomeController : BootstrapBaseController
    {
        public ActionResult Index()
        {
            //return View(Db.Lists.ToList());
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
