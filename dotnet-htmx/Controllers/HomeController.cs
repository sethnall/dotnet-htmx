using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_htmx.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Htmx;

namespace dotnet_htmx.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/GetHelloWorld")]
    public IActionResult GetHelloWorld()
    {
        // Handle HTMX request
        return Content("<span>Let's get coffee!</span>", "text/html");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

