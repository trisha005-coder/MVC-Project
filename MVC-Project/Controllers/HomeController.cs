using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Profile()
    {
        var Model = new Details
        {
            FullName = "Trisha Mae A. Mercado",
            Age = 21,
            emailAdd = "trishamaemercado06@gmail.com",
            ContactNo = "09169586419",
            Address = "Antipolo City",
            Qualities = new List<string> { "Good communication skills", "Responsible", "Can handle tasks efficiently", "Honest", },
            Skills = new List<string> { "C", "Java", "Python", "SQL", "C#" },
            MyHobbies = new List<string> { "Drawing", "Reading", "Playing with pet cats", "Listening to music" }
        };
        return View(Model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
