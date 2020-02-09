using Crowdfunding.Data.Interfaces;
using Crowdfunding.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data.Repository
{
    public class ProjectRepository : IAllProjects
    {
        private readonly AppDBContent AppDBContent;
        public ProjectRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }
        public IEnumerable<Project> Projects => AppDBContent.Project.Include(c => c.Category);
        public IEnumerable<Project> GetFavProjects => AppDBContent.Project.Where(pi => pi.IsFavourite).Include(c => c.Category);

        public Project GetObjectProject(int ProjectID) => AppDBContent.Project.FirstOrDefault(p => p.Id == ProjectID);
    }
}
