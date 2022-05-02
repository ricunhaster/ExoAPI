

using ExoAPI.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoAPI.WebAPI.Contexts
{
    public class ExoContexts : DbContext
    {
        public ExoContexts()
        {
        }
            public ExoContexts(DbContextOptions<ExoContexts>options) : base(options)
            {
            }
            protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source = DESKTOP-ABL8OLJ\\SQLEXPRESS; initial catalog = Exo; Integrated Security = true");
                }
            }

        public DbSet<ExoProjeto>? Projects { get; set; }

    }
}
