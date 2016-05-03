using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class AddEditDeveloper
    {
        public Developer Developer { get; set; }
        public List<DeveloperInfo> DeveloperInfoList { get; set; }
        public DeveloperSkill DeveloperSkill { get; set; }

        public AddEditDeveloper()
        {
            DeveloperInfoList = new List<DeveloperInfo>();
        }
    }

  
}
