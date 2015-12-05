using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class PortfolioDbEntities : DbContext
    {
        public PortfolioDbEntities() : base("name=ConnectionString")
        {

        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<DeveloperInfo> DeveloperInfos { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
