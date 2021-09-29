using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/place")]
    public ActionResult HomePage()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/place/new")]
    public ActionResult NewPlace() 
    { 
      return View(); 
    }

    [HttpPost("/place")]
    public ActionResult Create(string city)
    {
      Place testPlace = new Place(city);
      // return View("HomePage", testPlace);
      return RedirectToAction("HomePage");
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