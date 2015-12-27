using System.Data.Entity;
using BOL;

namespace BOL
{
    public class PortfolioDbEntities : DbContext
    {
        public PortfolioDbEntities() : base("name=ConnectionString")
        {

        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<DeveloperInfo> DeveloperInfos { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<DeveloperSkill> DeveloperSkills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeveloperSkill>().
                HasKey(ds => new { ds.DeveloperId, ds.SkillId });

            modelBuilder.Entity<Developer>()
                .HasMany(d => d.DeveloperSkills)
                .WithRequired()
                .HasForeignKey(ds => ds.DeveloperId);

            modelBuilder.Entity<Skill>()
                .HasMany(s => s.DeveloperSkills)
                .WithRequired()
                .HasForeignKey(ds => ds.SkillId);
        }
    }
}
