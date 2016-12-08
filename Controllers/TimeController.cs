using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay.Controllers
{
 public class TimeDisplayController : Controller
 {
  [HttpGet]
  [Route("")]
  public IActionResult Index()
  {
      DateTime CurrentTime = DateTime.Now;
      ViewBag.datetime = CurrentTime.ToString("MMMM dd, yyyy hh:mm tt");
      Console.WriteLine(CurrentTime);
      return View("home");
  }
 }
}
