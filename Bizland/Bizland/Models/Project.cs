using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland.Models
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public Category Category { get; set; }
    }
}
