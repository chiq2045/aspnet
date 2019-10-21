using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnet.Controllers
{
  public class MovieAppController : Controller
  {
    // GET: /MovieApp/
    public ActionResult Index()
    {
      return View();
    }

    // Get: /MovieApp/List/
    public ActionResult List()
    {
      return View();
    }

    // GET: /MovieApp/Welcome/
    public ActionResult Welcome(string name, int repeat = 1)
    {
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = repeat;

      return View();
    }
  }
}
