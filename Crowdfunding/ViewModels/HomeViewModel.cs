using Crowdfunding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Project> FavProjects { get; set; }

        //public IEnumerable<Category> AllCategories { get; set; }
    }
}
