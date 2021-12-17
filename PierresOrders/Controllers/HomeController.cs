using Microsoft.AspNetCore.Mvc;

namespace PierresOrders.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}