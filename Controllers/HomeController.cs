using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = PortfolioData.Create();
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
