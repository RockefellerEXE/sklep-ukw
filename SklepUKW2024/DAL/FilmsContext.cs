using Microsoft.EntityFrameworkCore;
using SklepUKW2024.Models;

namespace SklepUKW2024.DAL
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

            modelBuilder.Entity<Film>().HasData(
                  new Film()
                  {
                      FilmId = 11,
                      CategoryId = 1,
                      Title = "Teksańska Masakra Piłą Mechaniczną",
                      Director = "Marcus Nispel",
                      Desc = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                      Price = 10,
                      AddDate = new DateTime(2020, 5, 4),
                      Poster = "teksanska-masakra-pila-mechaniczna.jpg"
                  },
                new Film()
                {
                    FilmId = 12,
                    CategoryId = 3,
                    Title = "Numer 23",
                    Director = "Joel Schumacher",
                    Desc = "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.",
                    Price = 14,
                    AddDate = new DateTime(2021, 3, 16),
                    Poster = "numer-23.jpg"
                },
                new Film()
                {
                    FilmId = 13,
                    CategoryId = 3,
                    Title = "Sekretne Okno",
                    Director = "David Koepp",
                    Desc = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                    Price = 12,
                    AddDate = new DateTime(2020, 5, 4),
                    Poster = "sekretne-okno.jpg"
                },
                new Film()
                {
                    FilmId = 4,
                    CategoryId = 5,
                    Title = "Władca Pierścieni: Drużyna Pierścienia",
                    Director = "Peter Jackson",
                    Desc = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                    Price = 20,
                    AddDate = new DateTime(2020, 5, 4),
                    Poster = "wladca-pierscieni-druzyna-pierscienia.jpg"
                },
                new Film()
                {
                    FilmId = 5,
                    CategoryId = 4,
                    Title = "Red",
                    Director = "Robert Schwentke",
                    Desc = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                    Price = 11,
                    AddDate = new DateTime(2020, 5, 4),
                    Poster = "red.jpg"
                },
                new Film()
                {
                    FilmId = 6,
                    CategoryId = 2,
                    Title = "Tylko nie mów nikomu",
                    Director = "Tomasz Sekielski",
                    Desc = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                    Price = 0,
                    AddDate = new DateTime(2021, 4, 4),
                    Poster = "tylko-nie-mow-nikomu.jpg"
                },
                new Film()
                {
                    FilmId = 7,
                    CategoryId = 5,
                    Title = "Iluzjonista",
                    Director = "Neil Burger",
                    Desc = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                    Price = 13,
                    AddDate = new DateTime(2020, 5, 4),
                    Poster = "iluzjonista.jpg"
                },
                new Film()
                {
                    FilmId = 8,
                    CategoryId = 3,
                    Title = "Cube",
                    Director = "Vincenzo Natali",
                    Desc = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                    Price = 15,
                    AddDate = new DateTime(2021, 2, 1),
                    Poster = "cube.jpg"
                },
                new Film()
                {
                    FilmId = 9,
                    CategoryId = 1,
                    Title = "Hellraiser: Wysłannik Piekieł",
                    Director = "Clive Barker",
                    Desc = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                    Price = 16,
                    AddDate = new DateTime(2020, 6, 21),
                    Poster = "hellriser.jpg"
                },
                new Film()
                {
                    FilmId = 10,
                    CategoryId = 3,
                    Title = "Milczenie Owiec",
                    Director = "Jonathan Demme",
                    Desc = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                    Price = 17,
                    AddDate = new DateTime(2020, 10, 10),
                    Poster = "milczenie-owiec.jpg"
                });




            modelBuilder.Entity<Film>().HasData(
                new Film()
                {
                    FilmId = 21,
                    CategoryId = 4,
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Desc = "Zespół specjalistów wkracza w umysł biznesmena, aby zaimplantować tam myśl.",
                    Price = 12,
                    AddDate = new DateTime(2020, 5, 21)
                },
    new Film()
    {
        FilmId = 22,
        CategoryId = 3,
        Title = "Gone Girl",
        Director = "David Fincher",
        Desc = "Kiedy zaginie żona, mąż staje się głównym podejrzanym, ale sytuacja jest bardziej skomplikowana niż się wydaje.",
		Price = 12,
		AddDate = new DateTime(2020, 5, 21)
	},
    new Film()
    {
        FilmId = 23,
        CategoryId = 1,
        Title = "The Exorcist",
        Director = "William Friedkin",
        Desc = "Kiedy młoda dziewczyna zostaje opętana przez złego ducha, ksiądz próbuje jej pomóc.",
		Price = 15,
		AddDate = new DateTime(2024, 1, 21)
	},
    new Film()
    {
        FilmId = 24,
        CategoryId = 2,
        Title = "March of the Penguins",
        Director = "Luc Jacquet",
        Desc = "Dokumentalny opis życia pingwinów cesarskich w Antarktyce.",
		Price = 21,
		AddDate = new DateTime(2024, 2, 11)
	},
    new Film()
    {
        FilmId = 25,
        CategoryId = 5,
        Title = "The Lord of the Rings: The Fellowship of the Ring",
        Director = "Peter Jackson",
        Desc = "Młody hobbit wyrusza w podróż, aby zniszczyć pierścień, który może zniszczyć świat.",
		Price = 10,
		AddDate = new DateTime(2021, 9, 30)
	},
    new Film()
    {
        FilmId = 26,
        CategoryId = 3,
        Title = "Se7en",
        Director = "David Fincher",
        Desc = "Dwóch detektywów tropi seryjnego mordercę, który działa według siedmiu grzechów głównych.",
		Price = 14,
		AddDate = new DateTime(2022, 6, 1)
	},
    new Film()
    {
        FilmId = 27,
        CategoryId = 4,
        Title = "Die Hard",
        Director = "John McTiernan",
        Desc = "Policyjny porucznik staje w obronie budynku, który został przejęty przez terrorystów.",
		Price = 9,
		AddDate = new DateTime(2019, 3, 3)
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
    // Pozostałe filmy w podobny sposób...
    new Film()
    {
        FilmId = 20,
        CategoryId = 5,
        Title = "Harry Potter and the Philosopher's Stone",
        Director = "Chris Columbus",
        Desc = "Młody czarodziej Harry Potter odkrywa swoje magiczne dziedzictwo, gdy zostaje zaproszony do Hogwartu."
    }
                );


            modelBuilder.Entity<Category>().HasData(
                new Category { 
                    CategoryId = 1,
                    Name = "Horror",
                    Desc = "Straszne filmy"
                },
                new Category { 
                    CategoryId = 2,
                    Name = "Dokumentalne",
                    Desc = "Filmy oparte na faktach"
                },
                new Category { 
                    CategoryId = 3,
                    Name = "Thriller",
                    Desc = "Dreszczowce"
                },
                new Category { 
                    CategoryId = 4,
                    Name = "Sensacyjne",
                    Desc = "Filmy z akcją"
                },
                new Category { 
                    CategoryId = 5,
                    Name = "Fantasy",
                    Desc = "Elementy magiczne i nadprzyrodzone"
                }
                
                );
        }
    }
}
