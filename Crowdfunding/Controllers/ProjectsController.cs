using Crowdfunding.Data.Interfaces;
using Crowdfunding.Data.Models;
using Crowdfunding.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IAllProjects _allProjects;
        private readonly IProjectsCategory _allCategories;

        public ProjectsController(IAllProjects iallProjects, IProjectsCategory iprojCat)
        {
            _allProjects = iallProjects;
            _allCategories = iprojCat;
        }
        [Route("Projects/List")]
        [Route("Projects/List/{Category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Project> projects = null;
            string CurrentCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                projects = _allProjects.Projects.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Music", category, StringComparison.OrdinalIgnoreCase))
                {
                    projects = _allProjects.Projects.Where(i => i.Category.CategoryName.Equals("Music")).OrderBy(i => i.Id);
                }
                else if (string.Equals("VideoGames", category, StringComparison.OrdinalIgnoreCase))
                {
                    projects = _allProjects.Projects.Where(i => i.Category.CategoryName.Equals("VideoGames")).OrderBy(i => i.Id);
                }

                CurrentCategory = _category;


            }
            var ProjectObj = new ProjectsListViewModel
            {
                AllProjects = projects,
                CurrentCategory = _category
            };               

            ViewBag.Title = "Projects list";
            return View(ProjectObj);
        }

        public ViewResult ThisProject(string projectName)
        {
            IEnumerable<Project> projects = null;
            projects = _allProjects.Projects.Where(i => i.Name.Equals(projectName));
            string _category = "";
            //return View(project);
            var ProjectObj = new ProjectsListViewModel
            {
                AllProjects = projects,
                CurrentCategory = _category
            };

            ViewBag.Title = "Projects list";
            return View(ProjectObj);
        }
    }
}
