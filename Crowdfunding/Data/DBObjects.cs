using Crowdfunding.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent Content)
        {                    

            if(!Content.Category.Any())
            {
                Content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!Content.Project.Any())
            {
                Content.AddRange
                (
                    new Project
                    {
                        Name = "RaceSimulator3000",
                        ShortDescription = "New race videogame",
                        LongDescription = "Videogame with new cars and new roads",
                        Img = "https://www.maximonline.ru/images/th/100/18/99844-MTE3NjM1OTk1Yg.jpg",
                        IsFavourite = true,
                        Category = Categories["VideoGames"]
                    },
                    new Project
                    {
                        Name = "Goat",
                        ShortDescription = "New album",
                        LongDescription = "Writing new album 'Goat'",
                        Img = "https://upload.wikimedia.org/wikipedia/ru/e/e6/Goat_Simulator_logo.png",
                        IsFavourite = true,
                        Category = Categories["Music"]
                    }
                );
            }
            Content.SaveChanges();
        }
        private static Dictionary<string, Category> Category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(Category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Music", Description = "New albums, new instruments and so on"},
                        new Category {CategoryName = "VideoGames", Description = "New videogames and so on"}
                    };

                    Category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        Category.Add(el.CategoryName, el);
                    }
                }
                return Category;
            }
        }
    }
}
