using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PortfolioSite.Models
{
    public class PortfolioDBContext : DbContext
    {
        public PortfolioDBContext() : base("PortfolioDB") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
