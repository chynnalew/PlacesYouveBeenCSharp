using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

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
    [TestMethod]
    public void GetAll_StoresItemInList_True()
    {
      Place testPlace = new Place("name");
      List<Place> testList = Place.GetAll();
      Assert.AreEqual(testList[0].CityName, testPlace.CityName);
    }
    [TestMethod]
    public void ClearAll_ClearsItemsInList_True()
    {
      Place testPlace = new Place("name");
      Place.ClearAll();
      List<Place> testList = Place.GetAll();
      List<Place> emptyList = new List<Place> {};
      CollectionAssert.AreEqual(testList, emptyList);
    }
  }
}