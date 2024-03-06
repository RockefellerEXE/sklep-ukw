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
    }
}
