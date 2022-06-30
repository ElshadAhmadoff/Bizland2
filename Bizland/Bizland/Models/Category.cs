using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}
