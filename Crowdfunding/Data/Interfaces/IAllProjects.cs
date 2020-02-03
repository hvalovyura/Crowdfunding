using Crowdfunding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data.Interfaces
{
    interface IAllProjects
    {
        IEnumerable<Project> Projects { get; }

        IEnumerable<Project> GetFavCars { get; }

        Project GetObjectProject(int ProjectID);
    }
}
