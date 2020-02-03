using Crowdfunding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data.Interfaces
{
    interface IProjectsCategory
    {
        IEnumerable<Category> AllCategories { get;  }
    }
}
