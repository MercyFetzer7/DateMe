using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateMe.Models;

namespace DateMe.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult DatingApplication()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DatingApplication(Application response)
    {
        return View("Confirmation", response);
    }
}