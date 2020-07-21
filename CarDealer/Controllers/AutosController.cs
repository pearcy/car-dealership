using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    { 
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description, int miles, bool accident, int price)
    {
      Item myItem = new Item(description, miles, accident, price);
      return RedirectToAction("Index");
    }
  }
}
