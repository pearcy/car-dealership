using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Item
  {

    private string _description { get; set; }
    private int _miles { get; set; }
    private bool _accident { get; set; }
    private int _price { get; set; }
    

    private static List<Item> _instances = new List<Item> {};

    // public int Priority { get; set; } = 1;

    public Item(string description, int miles, bool accident, int price)
    {
      _description = description;
      _miles = miles;
      _accident = accident;
      _price = price;
      _instances.Add(this);
    }

    // public Item(string description, int priority): this(description)
    // {
    //   Priority = priority;
    // }
    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}

