using Crowdfunding.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Projects list";
            ProjectsListViewModel obj = new ProjectsListViewModel();
            obj.AllProjects = _allProjects.Projects;
            obj.CurrentCategory = "Projects";
            return View(obj);
        }
    }
}
