using Microsoft.EntityFrameworkCore;
using ShoesAndHats.Models;
using System.Drawing;


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
            if (Shoes.Any()) return;
            Shoes shoes = new Shoes()
            {
                Size = 48,
                Brands = "Adidas",
                Color = "White",
                UrlImage = "https://m.media-amazon.com/images/I/716Inzq-uoL._AC_SL1500_.jpg"
            };
            Shoes.Add(shoes);
            SaveChanges();
        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }

        public DbSet<Hats>Hats { get; set; }

        public DbSet<Shoes> Shoes { get; set; }
    }
}
