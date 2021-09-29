using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/place/new")]
    public ActionResult NewPlace() 
    { 
      return View(); 
    }

    [HttpPost("/")]
    public ActionResult Create(string city)
    {
      Place testPlace = new Place(city);
      return View("HomePage", testPlace);
    }
  }
}

  //  [HttpGet("/items/new")]
  //   public ActionResult CreateForm()
  //   {
  //     return View();
  //   }

  //   [HttpPost("/items")]
  //   public ActionResult Create(string description)
  //   {
  //     Item myItem = new Item(description);
  //     return RedirectToAction("Index");
  //   }