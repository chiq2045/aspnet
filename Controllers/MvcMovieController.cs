using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnet.Controllers
{
    public class MvcMovieController : Controller
    {
        // GET: /MvcMovie/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}
