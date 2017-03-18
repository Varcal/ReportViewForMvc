using System.Web.Mvc;

namespace ReportViewerForMvc.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}