using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class DeveloperDb
    {
        private PortfolioDbEntities Db;

        public DeveloperDb()
        {
            Db = new PortfolioDbEntities();
        }

        public IEnumerable<Developer> GetAll()
        {
            return Db.Developers.ToList();
        }

        public Developer GetDeveloper(int Id)
        {
            return Db.Developers.Include("DeveloperInfo").Include("DeveloperSKills").Include("DeveloperSKills.Skill").SingleOrDefault(d => d.Id == Id);

           
        }
    }
}
