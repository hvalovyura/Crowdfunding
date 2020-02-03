using Crowdfunding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.ViewModels
{
    public class ProjectsListViewModel
    {
        public IEnumerable<Project> AllProjects { get; set; }

        public string CurrentCategory;
    }
}
