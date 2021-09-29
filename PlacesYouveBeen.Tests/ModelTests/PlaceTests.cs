using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void Place_CreatesNewInstanceOfPlace_True()
    {
      Place testPlace = new Place("name");
      Assert.AreEqual(typeof(Place), testPlace.GetType());
    }
    [TestMethod]
    public void Place_StoresCityName_True()
    {
      Place testPlace = new Place("name");
      Assert.AreEqual("name", testPlace.CityName);
    }
  }
}