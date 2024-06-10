namespace SklepUKW2024.Models
{
	public class AddFilmViewModel
	{
        public Film Film { get; set; }

        public List<Category> Categories { get; set; }

        public IFormFile Poster { get; set; }
    }
}
