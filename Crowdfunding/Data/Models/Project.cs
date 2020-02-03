using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowdfunding.Data.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Img { get; set; }

        public bool IsFavourite { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
