using Microsoft.EntityFrameworkCore;
using Pop_Mihai_Lab.Models;

namespace Pop_Mihai_Lab.Data
{
    public class Pop_Mihai_LabContext : DbContext
    {
        public Pop_Mihai_LabContext (DbContextOptions<Pop_Mihai_LabContext> options)
            : base(options)
        {
        }

        public DbSet<Pop_Mihai_Lab.Models.Produs> Produs { get; set; }

        public DbSet<Pop_Mihai_Lab.Models.Client> Client { get; set; }

        public DbSet<Pop_Mihai_Lab.Models.Comanda> Comanda { get; set; }


    }
}
