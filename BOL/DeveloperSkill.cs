﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public class DeveloperSkill
    {
        public int DeveloperId { get; set; }
        public int SkillId { get; set; }
        public Developer Developer { get; set; }
        public Skill Skill { get; set; }
        public int Rate { get; set; }
    }
}
