using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateMe.Models;

namespace DateMe.Controllers;

public class HomeController : Controller
{
    private DatingApplicationContext _context;
    public HomeController(DatingApplicationContext temp) // Constructor
    {
        _context = temp;
    }
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
        _context.Applications.Add(response); // add record to the database
        _context.SaveChanges(); // commit the changes
        return View("Confirmation", response);
    }
}