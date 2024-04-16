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
            modelBuilder.Entity<Film>().HasData(
                new Film()
                {
                    FilmId = 21,
                    CategoryId = 4,
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Desc = "Zespół specjalistów wkracza w umysł biznesmena, aby zaimplantować tam myśl.",
                    Price = 15,
                    AddDate = new DateTime(2010,7,8)
                },
                new Film()
                {
                    FilmId = 22,
                    CategoryId = 3,
                    Title = "Gone Girl",
                    Director = "David Fincher",
                    Desc = "Kiedy zaginie żona, mąż staje się głównym podejrzanym, ale sytuacja jest bardziej skomplikowana niż się wydaje.",
                    Price = 35,
                    AddDate = new DateTime(2012, 2, 23)
                },
                new Film()
                {
                    FilmId = 23,
                    CategoryId = 1,
                    Title = "The Exorcist",
                    Director = "William Friedkin",
                    Desc = "Kiedy młoda dziewczyna zostaje opętana przez złego ducha, ksiądz próbuje jej pomóc.",
                    Price = 5,
                    AddDate = new DateTime(2010, 11, 12)
                },
                new Film()
                {
                    FilmId = 24,
                    CategoryId = 2,
                    Title = "March of the Penguins",
                    Director = "Luc Jacquet",
                    Desc = "Dokumentalny opis życia pingwinów cesarskich w Antarktyce."
                },
                new Film()
                {
                    FilmId = 25,
                    CategoryId = 5,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Director = "Peter Jackson",
                    Desc = "Młody hobbit wyrusza w podróż, aby zniszczyć pierścień, który może zniszczyć świat."
                },
                new Film()
                {
                    FilmId = 26,
                    CategoryId = 3,
                    Title = "Se7en",
                    Director = "David Fincher",
                    Desc = "Dwóch detektywów tropi seryjnego mordercę, który działa według siedmiu grzechów głównych."
                },
                new Film()
                {
                    FilmId = 27,
                    CategoryId = 4,
                    Title = "Die Hard",
                    Director = "John McTiernan",
                    Desc = "Policyjny porucznik staje w obronie budynku, który został przejęty przez terrorystów."
                },
                new Film()
                {
                    FilmId = 28,
                    CategoryId = 1,
                    Title = "A Nightmare on Elm Street",
                    Director = "Wes Craven",
                    Desc = "Grupa nastolatków odkrywa, że śmiercionośny morderca grasuje we śniech."
                },
                new Film()
                {
                    FilmId = 29,
                    CategoryId = 2,
                    Title = "Blackfish",
                    Director = "Gabriela Cowperthwaite",
                    Desc = "Kontrowersyjny dokument o światach orków i ich warunkach życia w niewoli."
                },
                new Film()
                {
                    FilmId = 30,
                    CategoryId = 5,
                    Title = "Pan's Labyrinth",
                    Director = "Guillermo del Toro",
                    Desc = "W Hiszpanii podczas wojny domowej dziewczynka odkrywa magiczny labirynt w lesie."
                },
             new Film()
             {
                 FilmId = 1,
                 CategoryId = 1,
                 Title = "The Shining",
                 Director = "Stanley Kubrick",
                 Desc = "Rodzina zamieszkuje opuszczony hotel, gdzie ojciec zaczyna stopniowo tracić zmysły."
             },
                new Film()
                {
                    FilmId = 2,
                    CategoryId = 1,
                    Title = "Psycho",
                    Director = "Alfred Hitchcock",
                    Desc = "Kobieta trafia do odległego motelu, gdzie właściciel ma mroczne sekrety."
                },
                new Film()
                {
                    FilmId = 3,
                    CategoryId = 2,
                    Title = "Planet Earth II",
                    Director = "David Attenborough",
                    Desc = "Seria dokumentalna przedstawiająca niesamowite zjawiska przyrody na całym świecie."
                },
                new Film()
                {
                    FilmId = 20,
                    CategoryId = 5,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Director = "Chris Columbus",
                    Desc = "Młody czarodziej Harry Potter odkrywa swoje magiczne dziedzictwo, gdy zostaje zaproszony do Hogwartu."
                }
                );
        }
    }
}
