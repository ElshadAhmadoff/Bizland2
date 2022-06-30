using Bizland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> categories { get; set; }
        public List<Project> projects { get; set; }

    }
}
