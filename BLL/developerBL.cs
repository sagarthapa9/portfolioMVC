using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class DeveloperBl
    {
        private readonly DeveloperDb _objDb;

        public DeveloperBl()
        {
           _objDb = new DeveloperDb();
        }

        public IEnumerable<Developer> GetAll()
        {
            return _objDb.GetAll();
        }

        public Developer GetById(int Id)
        {
            return _objDb.GetDeveloper(Id);
        }

        public void Insert(Developer dev)
        {
            _objDb.AddDeveloper(dev);
        }

    }
}
