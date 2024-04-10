

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepUKW.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        [Required(ErrorMessage = "Brak tytułu")]
        public string Title { get; set; }
        public string Director { get; set; }

        [StringLength(500)]
        public string Desc { get; set; }

        public double? Price { get; set; }

        public DateTime? AddDate { get; set; }

        public string? Poster { get; set; }

        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }

}