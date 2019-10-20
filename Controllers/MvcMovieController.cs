using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnet.Controllers
{
  public class HelloWorldController : Controller
  {
    // GET: /HelloWorld/
    public string Index()
    {
      return "This is my default action...";
    }

    // GET: /HelloWorld/Welcome
    public string Welcome(string name, int id = 1)
    {
      return HtmlEncoder.Default.Encode($"HEllo {name}, ID is {id}");
    }
  }
}
