namespace SklepUKW2024.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
