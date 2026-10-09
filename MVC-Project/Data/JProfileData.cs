
using MVC_Project.Models;

namespace MVC_Project.Data
{
    public class JProfileData
    {
        private JProfileViewModel JProfile = new JProfileViewModel() 
        {
            Name = "Joanna Gorospe",
            Major = "Computer Science",
            Education = "Polytechnic University of the Philippines",
            Languages = {"Filipino", "English"},
            PLanguages = {"C", "C#", "Java", "HTML", "CSS"},
            Interests =
            {
                new JInterestModel
                {
                    Interest = "Creative Writing",
                    Details = 
                    {
                        "Character Concepts", 
                        "Worldbuilding",
                        "Drabbles"
                    }
                },
                new JInterestModel 
                { 
                    Interest = "Video Editing", 
                    Details =
                    {
                        "Canva Video Editor",
                        "Kdenlive"
                    }
                },
                new JInterestModel 
                { 
                    Interest = "Drawing", 
                    Details = 
                    {
                        "Paper & Pencil",
                        "Drawing Tablet",
                        "Fire Alpaca",
                        "MediBang",
                        "Ibis Paint",
                        "Magma"
                    }  
                },
                new JInterestModel 
                { 
                    Interest = "Planning & Designing Projects", 
                    Details =
                    {
                        "Canva",
                        "Figma",
                        "Google Suite",
                        "Microsoft Suite",
                        "Obsidian",
                        "Notion",
                        "Trello"
                    }
                },
                new JInterestModel
                {
                    Interest = "Gaming",
                    Details = 
                    {
                        "Limbus Company", 
                        "Honkai: Star Rail", 
                        "Don't Starve Together", 
                        "Stardew Valley", 
                        "Interactive Fiction/Visual Novels", 
                        "Story-driven Games", 
                        "Resource Management/Survival Games"
                    }
                },
                new JInterestModel { Interest = "Horror Video Essays" },
            },
            Projects =
            {
                new JProjectModel
                {
                    ProjectTitle = "BAYADPO: Student Organization Financial Tracking System (SOFTCS)",
                    Context = "Information Management Course Project",
                    ProjDescription = "A database SQL script prototype to automate financial logging and contribution tracking for student organizations",
                    Technologies = {"SQLite"},
                    TeamSize = 1,
                    TeamRole = "Database Designer",
                    Year = 2026
                },
                new JProjectModel
                {
                    ProjectTitle = "Janitoroute",
                    Context = "Design & Analysis of Algorithms Course Project",
                    ProjDescription = "A campus waste management and BFS route optimization mobile app MVP deployed on Expo Go to assist campus janitors.",
                    Technologies = {"React Native", "Expo", "Supabase"},
                    TeamSize = 4,
                    TeamRole = "Full Stack Developer",
                    Year = 2026
                },
                new JProjectModel
                {
                    ProjectTitle = "Pentimento",
                    Context = "TPG PUP Unlock() Game Jam",
                    ProjDescription = "A game concept and pitch deck of a narrative-driven psychological puzzle game about an painter's psyche. Won Best in Art Direction.",
                    Technologies = {"Godot 4 Framework"},
                    TeamSize = 4,
                    TeamName = "Brainrot Central",
                    TeamRole = "Game Designer & Developer",
                    Year = 2025
                },
                new JProjectModel
                {
                    ProjectTitle = "1agoon",
                    Context = "AWSCC PUP Solar Power Hackathon",
                    ProjDescription = "A menu web app for food stalls and services in the PUP Sta. Mesa Lagoon area.",
                    Technologies = {"React", "AWS (S3, ECR, Lambda)", "Supabase"},
                    TeamSize = 4,
                    TeamName = "4VATARS",
                    TeamRole = "Backend Developer",
                    Year = 2025
                },
                new JProjectModel
                {
                    ProjectTitle = "1agoon",
                    Context = "AWSCC PUP Solar Power Hackathon",
                    ProjDescription = "A menu web app for food stalls and services in the PUP Sta. Mesa Lagoon area.",
                    Technologies = {"React", "AWS (S3, ECR, Lambda)", "Supabase"},
                    TeamSize = 4,
                    TeamName = "4VATARS",
                    TeamRole = "Backend Developer",
                    Year = 2025
                },
                new JProjectModel
                {
                    ProjectTitle = "The Hanged Man",
                    Context = "GDG PUP CTRL+CREATE: Game Jam",
                    ProjDescription = "A story-rich 2D pixel psychological horror puzzle game prototype. Won Best in Art Direction.",
                    Technologies = {"Godot 4"},
                    TeamSize = 4,
                    TeamName = "Chariot Studios",
                    TeamRole = "Game Designer & Narrative Writer",
                    Year = 2025
                }
            }
        };

        public JProfileViewModel GetProfile()
        {
            return JProfile;
        }

        public List<JQuoteModel> GetQuotes()
        {
            return new List<JQuoteModel>
            {
                new JQuoteModel
                {
                    Quote = "Even a life marked by failure is a life worth living — it is only in moments of solitude and despair, when help is absent, that fools grasp how to pick themselves up.",
                    Author = "Dr. Veritas Ratio / Honkai: Star Rail"
                },
                new JQuoteModel
                {
                    Quote = "When we… or at least I saw your mirror, I thought I was seeing what we didn’t have. That’s why they seemed so far, and that’s why I could only look. It’s why I had to settle for this reality. But the mirror... What it shows are possibilities. You don’t have to envy the mirrored images. What you saw… were the possibilities you held. You’ve had them all along.",
                    Author = "Dongbaek / Limbus Company"
                },
                new JQuoteModel
                {
                    Quote = "It's you. Despite everything, it's still you.",
                    Author = "/Undertale"
                }  
            };
        }

        public List<string> GetTitles()
        {
            return new List<string>
            {
                "Storywriter",
                "Game Designer & Developer",
                "Student Developer",
                "Aspiring Full-Stack Developer",
                "Beginner Artist",
                "Computer Science Student",
                "Beginner Video Editor"
            };
        }
    }
}