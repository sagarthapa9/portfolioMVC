using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BOL;



namespace DAL
{
    public class PortFolioIntializer : DropCreateDatabaseIfModelChanges<PortfolioDbEntities>
    {
        protected override void Seed(PortfolioDbEntities context)
        {
            var developers = new List<Developer>
            {
                new Developer
                {
                    Name = "Sagar Thapa",
                    Title = "Web Application & Software Developer",
                    Tag = "I am passionate about taking an idea & making it into a Digitized Reality."
                },
                new Developer
                {
                    Name = "Jason",
                    Title = "ASP.NET/C# Programer & Front-end Developer",
                    Tag = "I have a passion for the details. I strive to develop design websites that Comes to life."
                }
            };
            developers.ForEach(d => context.Developers.Add(d));
            context.SaveChanges();

            var developerInfos = new List<DeveloperInfo>
            {
                new DeveloperInfo
                {
                    DeveloperId = 1,
                    Title = "--Who am I--",
                    Description =
                        "'Hello I am Sagar Thapa; I am a developer and designer currently residing in Oxford.I am currently looking for opportunity to enhance my programming, analytical, creative and problem solving skills and pursue my career in the competitive world of web based application development.'"
                },
                new DeveloperInfo
                {
                    DeveloperId = 1,
                    Title = "--What I do--",
                    Description =
                        "I love to create and build websites using front-end and .net technologies for developing state of art web applications with minute details and presicion."
                },
                 new DeveloperInfo
                {
                    DeveloperId = 1,
                    Title = "--What I Know--",
                    Description =
                        "I have been researching, designing and developing websites using HTML5, CSS3, JavaScript/Jquery , C# language, ASP.NET 2.0/3.5/4.0 Framework, SQL Server 2005/2008 ,SEO using Visual Studio 2008/2010 because my skills and experience lend themselves most readily to this areas."
                },
                new DeveloperInfo
                {   DeveloperId = 1,
                    Title = "--What I Love--",
                    Description =
                        "I am passionate about learning innovative and creative technologies. I thrive on understanding new concepts and ideas in order to enhance my skills."
                },
                new DeveloperInfo
                {
                    DeveloperId = 2,
                    Title = "--What I Love--",
                    Description =
                        "I am passionate about learning innovative and creative technologies. I thrive on understanding new concepts and ideas in order to enhance my skills."
                },
                new DeveloperInfo
                {
                    DeveloperId = 2,
                    Title = "What I am Good at..",
                    Description =
                        "I have always been keen about designing and developing professional web applications which can be implemented in real business world providing best business solutions that can help in transformation and growth of business.Hence I have always been enthusiastic about learning programming languages and software design techniques. I have worked on various college projects where I developed web applications. The following graph shows proficiency of the skills I have achieved in the course of pursuing my career as web developer."
                },
                                new DeveloperInfo
                {
                    DeveloperId = 2,
                    Title = "--Who am I--",
                    Description =
                        "'Hello I am Sagar Thapa; I am a developer and designer currently residing in Oxford.I am currently looking for opportunity to enhance my programming, analytical, creative and problem solving skills and pursue my career in the competitive world of web based application development.'"
                },
                new DeveloperInfo
                {
                   DeveloperId = 2,
                    Title = "--What I do--",
                    Description =
                        "I love to create and build websites using front-end and .net technologies for developing state of art web applications with minute details and presicion."
                },
                 new DeveloperInfo
                {
                   DeveloperId = 2,
                    Title = "--What I Know--",
                    Description =
                        "I have been researching, designing and developing websites using HTML5, CSS3, JavaScript/Jquery , C# language, ASP.NET 2.0/3.5/4.0 Framework, SQL Server 2005/2008 ,SEO using Visual Studio 2008/2010 because my skills and experience lend themselves most readily to this areas."
                },
                new DeveloperInfo
                {  DeveloperId = 2,
                    Title = "--What I Love--",
                    Description =
                        "I am passionate about learning innovative and creative technologies. I thrive on understanding new concepts and ideas in order to enhance my skills."
                },
                new DeveloperInfo
                {
                   DeveloperId = 2,
                    Title = "--What I Love--",
                    Description =
                        "I am passionate about learning innovative and creative technologies. I thrive on understanding new concepts and ideas in order to enhance my skills."
                },
                new DeveloperInfo
                {
                    DeveloperId = 2,
                    Title = "What I am Good at..",
                    Description =
                        "I have always been keen about designing and developing professional web applications which can be implemented in real business world providing best business solutions that can help in transformation and growth of business.Hence I have always been enthusiastic about learning programming languages and software design techniques. I have worked on various college projects where I developed web applications. The following graph shows proficiency of the skills I have achieved in the course of pursuing my career as web developer."
                }
            };
            developerInfos.ForEach(di => context.DeveloperInfos.Add(di));
            context.SaveChanges();

            var skills = new List<Skill>
            {
                new Skill {DeveloperSkill = "C#"},
                new Skill {DeveloperSkill = "ASP.NET"},
                new Skill {DeveloperSkill = "Javascript"},
                new Skill {DeveloperSkill = "HTML"},
                new Skill {DeveloperSkill = "CSS3"},
                new Skill {DeveloperSkill = "Service Stack"},
                new Skill {DeveloperSkill = "Jquery"},
                new Skill {DeveloperSkill = "AngularJs"}
            };

            skills.ForEach(s => context.Skills.Add(s));
            context.SaveChanges();

            var developerSkills = new List<DeveloperSkill>
            {
                new DeveloperSkill {DeveloperId = 1, SkillId = 1, Rate = 9},
                new DeveloperSkill {DeveloperId = 1, SkillId = 2, Rate = 8},
                new DeveloperSkill {DeveloperId = 1, SkillId = 3, Rate = 7},
                new DeveloperSkill {DeveloperId = 1, SkillId = 4, Rate = 9},
                new DeveloperSkill {DeveloperId = 1, SkillId = 5, Rate = 8},
                new DeveloperSkill {DeveloperId = 1, SkillId = 6, Rate = 9},
                new DeveloperSkill {DeveloperId = 1, SkillId = 7, Rate = 6},
                new DeveloperSkill {DeveloperId = 1, SkillId = 8, Rate = 7},
                new DeveloperSkill {DeveloperId = 2, SkillId = 1, Rate = 8},
                new DeveloperSkill {DeveloperId = 2, SkillId = 2, Rate = 9},
                new DeveloperSkill {DeveloperId = 2, SkillId = 3, Rate = 6},
                new DeveloperSkill {DeveloperId = 2, SkillId = 4, Rate = 9},
                new DeveloperSkill {DeveloperId = 2, SkillId = 5, Rate = 8},
                new DeveloperSkill {DeveloperId = 2, SkillId = 6, Rate = 6},
                new DeveloperSkill {DeveloperId = 2, SkillId = 7, Rate = 8},
                new DeveloperSkill {DeveloperId = 2, SkillId = 8, Rate = 9}
            };
            developerSkills.ForEach(ds => context.DeveloperSkills.Add(ds));
            context.SaveChanges();
        }
    }
}
