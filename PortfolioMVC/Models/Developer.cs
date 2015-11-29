using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioMVC.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public  string Tag { get; set; }
        public List<DeveloperInfo> DeveloperInfo { get; set; } 
    }
}