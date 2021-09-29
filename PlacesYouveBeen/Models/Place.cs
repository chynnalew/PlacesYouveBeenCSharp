using System;
using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Date { get; set;}

    public Place(string city, string date)
    {
      CityName = city;
      Date = date;
      _storedPlaces.Add(this);
    }

    private static List<Place> _storedPlaces = new List<Place> {};

    public static List<Place> GetAll()
    {
      return _storedPlaces;
    }

    public static void ClearAll()
    {
      _storedPlaces.Clear();
    }
  }
}