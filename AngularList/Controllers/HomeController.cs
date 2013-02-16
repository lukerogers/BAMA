using System.Linq;
using System.Web.Mvc;
using AngularList.Models;
using BootstrapMvcSample.Controllers;
using Omu.ValueInjecter;

namespace AngularList.Controllers
{
    public class HomeController : BootstrapBaseController
    {
        private AngularContext Db { get; set; }

        public HomeController()
        {
            Db = new AngularContext();
        }

        public ActionResult Index()
        {
            return View(Db.Lists.ToList());
        }

        public ActionResult Create(CreateList add)
        {
            var list = (List) new List().InjectFrom(add);
            Db.Lists.Add(list);
            Db.SaveChanges();
            return RedirectToAction("List", new { id = list.Id });
        }

        public ActionResult List(int id)
        {
            return View(Db.Lists.FirstOrDefault(x => x.Id == id));
        }
    }
}
