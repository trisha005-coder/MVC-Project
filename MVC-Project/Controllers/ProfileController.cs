using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
{
    public class ProfileController : Controller
    {
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
    }
}
