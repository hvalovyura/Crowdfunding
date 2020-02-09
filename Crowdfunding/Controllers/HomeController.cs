using Crowdfunding.Data.Interfaces;
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

        public HomeController(IAllProjects iallProjects)
        {
            _allProjects = iallProjects;
        }

        public ViewResult Index()
        {
            var HomeProjects = new HomeViewModel
            {
                FavProjects = _allProjects.GetFavProjects
            };
            return View(HomeProjects);
        }
    }
}
