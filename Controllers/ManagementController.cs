using System.Web.Mvc;

namespace Assignment.Areas.ContactDetails.Controllers
{
    public class ManagementController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Index(Models.ContactDetails details)
        {
            return View(details);
        }        
    }
}
