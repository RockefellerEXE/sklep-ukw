using Microsoft.EntityFrameworkCore;
using SklepUKW.Models;

namespace SklepUKW.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Horror",
                    Description = "Straszne filmy"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Dokumentalne",
                    Description = "Filmy oparte na faktach"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Thriller",
                    Description = "Dreszczowce"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Sensacyjne",
                    Description = "Filmy z akcją"
                },
                new Category
                {
                    CategoryId = 5,
                    Name = "Fantasy",
                    Description = "Filmy z elementami magi"
                }
               );
        }
    }
}
