using Crowdfunding.Data;
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
    public class HomeController : Controller
    {
        private readonly IAllProjects _allProjects;
        private readonly AppDBContent _content;

        public HomeController(IAllProjects iallProjects, AppDBContent content)
        {
            _allProjects = iallProjects;
            _content = content;
        }

        public ViewResult Index()
        {
            var HomeProjects = new HomeViewModel
            {
                FavProjects = _allProjects.GetFavProjects
            };
            return View(HomeProjects);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Project project)
        {
            project.IsFavourite = true;
            _content.Project.Add(project);
            _content.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
