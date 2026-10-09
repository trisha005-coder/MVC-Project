
namespace MVC_Project.Models
{
    public class JProfileViewModel
    {
        // Infobox section
        public string Name { get; set; } = "";
        public string Major { get; set; } = "";
        public string Education { get; set; } = "";
        public List<string> Languages { get; set; } = new List<string>();
        public List<string> PLanguages { get; set; } = new List<string>();
        // Beside Infobox section
        public List<JInterestModel> Interests { get; set; } = new List<JInterestModel>();
        // Project Gallery section
        public List<JProjectModel> Projects { get; set; } = new List<JProjectModel>();
    }

    public class JProjectModel
    {
        public string ProjectTitle { get; set; } = "";
        public string Context { get; set; } = "";
        public string ProjDescription { get; set; } = "";
        public List<string> Technologies { get; set; } = new List<string>();
        public int TeamSize { get; set; } = 0;
        public string? TeamName { get; set; } = "";
        public string? TeamRole { get; set; } = "";
        public int Year { get; set; } = 0;
    }

    public class JInterestModel
    {
        public string Interest { get; set; } = "";
        public List<string> Details { get; set; } = new List<string>();
    }

    public class JQuoteModel
    {
        public string Quote { get; set; } = "";
        public string Author { get; set; } = "";
    }
}
