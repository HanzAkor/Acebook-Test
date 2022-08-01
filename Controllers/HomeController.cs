using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Acebook.Models;

namespace Acebook.Controllers;

// inheriting from Controller
public class HomeController : Controller
{
    // attribute field
    private readonly ILogger<HomeController> _logger;

    //Constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Get route
    public IActionResult Index()
    {
        return View();
    }
    // Get route
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Terms_and_Conditions()
    {
        return View();
    }

     public IActionResult Signup()
    {
        return View();
    }

    // Error route
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
