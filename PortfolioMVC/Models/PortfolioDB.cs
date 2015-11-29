using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortfolioMVC.Models
{
    public class PortfolioDb:DbContext
    {
        public PortfolioDb() : base("name=ConnectionString")
        {

        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<DeveloperInfo> DeveloperInfos { get; set; }
    }
}