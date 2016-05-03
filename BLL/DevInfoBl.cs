using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
   public  class DevInfoBl
    {
        private readonly DevInfoDb _objDb;

        public DevInfoBl()
        {
            _objDb = new DevInfoDb();
        }

        public IEnumerable<DeveloperInfo> GetAll()
        {
            return _objDb.GetAll();
        }

        public DeveloperInfo GetById(int Id)
        {
            return _objDb.GetDeveloperInfo(Id);
        }

        public void Insert(DeveloperInfo dev)
        {
            _objDb.AddDeveloper(dev);
        }
    }
}
