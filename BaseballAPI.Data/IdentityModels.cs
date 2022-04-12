using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseballAPI.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; } 
        public DbSet<GameBattingStat> GameBattingStats { get; set; }
        public DbSet<GameInfo> Games { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameBattingStat>()
                .HasRequired(p => p.Player)
                .WithMany()
                .HasForeignKey(k => k.PlayerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<GameBattingStat>()
                .HasRequired(g => g.Game)
                .WithMany()
                .HasForeignKey(k => k.GameId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<GameInfo>()
                .HasRequired(g => g.HomeTeam)
                .WithMany()
                .HasForeignKey(k => k.TeamId1)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<GameInfo>()
                .HasRequired(g => g.AwayTeam)
                .WithMany()
                .HasForeignKey(k => k.TeamId2)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Player>()
                .HasRequired(t => t.Team)
                .WithMany()
                .HasForeignKey(k => k.TeamId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Team>()
                .HasRequired(p => p.Player)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Team>()
                .HasRequired(g => g.Game)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();
            modelBuilder
                .Configurations
                .Add(new IdentityUserLoginConfiguration())
                .Add(new IdentityUserRoleConfiguration());
        }
    }
    public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {
        public IdentityUserLoginConfiguration()
        {
            HasKey(IdentityUserLogin => IdentityUserLogin.UserId);
        }
    }
    public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {
        public IdentityUserRoleConfiguration()
        {
            HasKey(iur => iur.UserId);
        }
    }
}