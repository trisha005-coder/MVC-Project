using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using MVC_Project.Data;

namespace MVC_Project.Controllers;

public class JProfileController : Controller
{
    public IActionResult Index()
    {
        var JoannaProfile = new JProfileData().GetProfile();
        
        ViewBag.Titles = new JProfileData().GetTitles();
        ViewBag.Quotes = new JProfileData().GetQuotes();

        return View(JoannaProfile);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
