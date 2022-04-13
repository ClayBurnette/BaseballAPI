namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaseballAPI.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BaseballAPI.Data.ApplicationDbContext";
        }

        protected override void Seed(BaseballAPI.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Teams.AddOrUpdate(x => x.TeamId,
               new Team() { TeamId = 1 , TeamName = "Arizona Diamondbacks", TeamLocation = "Phoenix, Arizona", TeamMascot = "Timmy", TeamStadium = "Phoenix Stadium" }
                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
