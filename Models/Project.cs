using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortfolioSite.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public string GitHubLink { get; set; }
    }
}
