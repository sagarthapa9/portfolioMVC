using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioMVC.Models
{
    public class DeveloperInfo
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Skill> DeveloperSkills { get; set; } 
    }
}