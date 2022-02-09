using AngularForms.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularForms.Data
{
    public class App_Context :DbContext
    {

        public App_Context()
        {
        }

        public App_Context(DbContextOptions<App_Context> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AngualrFormsDB;Trusted_Connection=True;");
            }

        }
    }
}
