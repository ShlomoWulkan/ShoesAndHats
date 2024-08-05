using Microsoft.EntityFrameworkCore;
using ShoesAndHats.Models;


namespace MyLibrary.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            Database.EnsureCreated();
            //Seed();
        }
      
        private void Seed()
        {
          
        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }
        public DbSet<Hats>Hats { get; set; }
    }
}
