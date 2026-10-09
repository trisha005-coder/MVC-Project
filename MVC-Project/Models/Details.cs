using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models;

public class Details
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public string emailAdd { get; set; }
    public string ContactNo { get; set; }
    public string Address { get; set; }
    public List<string> Qualities { get; set; }
    public List<string> Skills { get; set; }
    public List<string> MyHobbies { get; set; }
}