using Microsoft.AspNetCore.Mvc;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Search(string search)
    {
      ViewBag.Results = _db.Clients.Where(client => client.Name == search).ToList();
      ViewBag.StylistResults = _db.Stylists.Where(stylist => stylist.StylistName == search).ToList();
      return View();
    }

  }
}