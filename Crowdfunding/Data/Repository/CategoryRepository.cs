using Crowdfunding.Data.Interfaces;
using Crowdfunding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data.Repository
{
    public class CategoryRepository : IProjectsCategory
    {
        private readonly AppDBContent AppDBContent;
        public CategoryRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }
        public IEnumerable<Category> AllCategories => AppDBContent.Category;
    }
}
