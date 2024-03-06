using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepUKW.Migrations
{
    public partial class Dane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desctription",
                table: "Films",
                newName: "Desc");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Straszne filmy", "Horror" },
                    { 2, "Filmy oparte na faktach", "Dokumentalne" },
                    { 3, "Dreszczowce", "Thriller" },
                    { 4, "Filmy z akcją", "Sensacyjne" },
                    { 5, "Filmy z elementami magi", "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rodzina zamieszkuje opuszczony hotel, gdzie ojciec zaczyna stopniowo tracić zmysły.", "Stanley Kubrick", "The Shining" },
                    { 2, 1, "Kobieta trafia do odległego motelu, gdzie właściciel ma mroczne sekrety.", "Alfred Hitchcock", "Psycho" },
                    { 3, 2, "Seria dokumentalna przedstawiająca niesamowite zjawiska przyrody na całym świecie.", "David Attenborough", "Planet Earth II" },
                    { 20, 5, "Młody czarodziej Harry Potter odkrywa swoje magiczne dziedzictwo, gdy zostaje zaproszony do Hogwartu.", "Chris Columbus", "Harry Potter and the Philosopher's Stone" },
                    { 21, 4, "Zespół specjalistów wkracza w umysł biznesmena, aby zaimplantować tam myśl.", "Christopher Nolan", "Inception" },
                    { 22, 3, "Kiedy zaginie żona, mąż staje się głównym podejrzanym, ale sytuacja jest bardziej skomplikowana niż się wydaje.", "David Fincher", "Gone Girl" },
                    { 23, 1, "Kiedy młoda dziewczyna zostaje opętana przez złego ducha, ksiądz próbuje jej pomóc.", "William Friedkin", "The Exorcist" },
                    { 24, 2, "Dokumentalny opis życia pingwinów cesarskich w Antarktyce.", "Luc Jacquet", "March of the Penguins" },
                    { 25, 5, "Młody hobbit wyrusza w podróż, aby zniszczyć pierścień, który może zniszczyć świat.", "Peter Jackson", "The Lord of the Rings: The Fellowship of the Ring" },
                    { 26, 3, "Dwóch detektywów tropi seryjnego mordercę, który działa według siedmiu grzechów głównych.", "David Fincher", "Se7en" },
                    { 27, 4, "Policyjny porucznik staje w obronie budynku, który został przejęty przez terrorystów.", "John McTiernan", "Die Hard" },
                    { 28, 1, "Grupa nastolatków odkrywa, że śmiercionośny morderca grasuje we śniech.", "Wes Craven", "A Nightmare on Elm Street" },
                    { 29, 2, "Kontrowersyjny dokument o światach orków i ich warunkach życia w niewoli.", "Gabriela Cowperthwaite", "Blackfish" },
                    { 30, 5, "W Hiszpanii podczas wojny domowej dziewczynka odkrywa magiczny labirynt w lesie.", "Guillermo del Toro", "Pan's Labyrinth" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Films",
                newName: "Desctription");
        }
    }
}
