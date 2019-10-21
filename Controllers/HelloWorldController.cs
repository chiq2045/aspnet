using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnet.Controllers
{
  public class HelloWorldController : Controller
  {
    // GET: /HelloWorld/
    public ActionResult Index()
    {
      return View();
    }

    // GET: /HelloWorld/Welcome
    public string Welcome(string name, int id = 1)
    {
      return HtmlEncoder.Default.Encode($"HEllo {name}, ID is {id}");
    }
  }
}
