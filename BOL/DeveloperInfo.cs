using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class DeveloperInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DeveloperId { get; set; }
        public string Description { get; set; }

        public virtual Developer Developer { get; set; }
    }
}
