﻿

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

        [StringLength(200)]
        public string Desctription { get; set; }

        //[ForeignKey("Category")]
        public int CategoryId { get; set;}

        public Category Category { get; set; }

    }
    
}
