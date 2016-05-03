using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class DevInfoDb
    {
        private readonly PortfolioDbEntities Db;

        public DevInfoDb()
        {
            Db = new PortfolioDbEntities();
        }

        public IEnumerable<DeveloperInfo> GetAll()
        {
            return Db.DeveloperInfos.ToList();
        }

        public DeveloperInfo GetDeveloperInfo(int Id)
        {
            return Db.DeveloperInfos.Include("DeveloperSKills").Include("DeveloperSKills.Skill").SingleOrDefault(d => d.Id == Id);
        }

        public void AddDeveloper(DeveloperInfo devObj)
        {
            Db.DeveloperInfos.Add(devObj);
            Save();
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}
