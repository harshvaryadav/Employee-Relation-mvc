using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee_Relation.Models;
using Microsoft.AspNetCore.Http;  
namespace Employee_Relation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["PrevPage"]=HttpContext.Session.GetString("PrevPage");  
        HttpContext.Session.SetString("PrevPage","Index");
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Username"]=HttpContext.Session.GetString("Username");   
        HttpContext.Session.SetString("PrevPage","Privacy");   
        if(ViewData["Username"]==null)
        {
           return RedirectToAction("Index","Home");  
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
