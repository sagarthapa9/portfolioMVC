using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BOL;

namespace BLL
{
    public class AdminBs
    {
        public DeveloperBl DevBs { get; set; }
        public DevInfoBl DevInfoBs { get; set; }
        public AdminBs()
        {
            DevBs = new DeveloperBl();
            DevInfoBs = new DevInfoBl();
        }

        public void AddDeveloperDetails(AddEditDeveloper dev)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                Developer d = dev.Developer;
                DevBs.Insert(d);

                List<DeveloperInfo> devInfo = dev.DeveloperInfoList;
                foreach (var info in devInfo)
                {
                    info.DeveloperId = d.Id;
                    DevInfoBs.Insert(info);
                }

                trans.Complete();
            }
        }
    }
}
