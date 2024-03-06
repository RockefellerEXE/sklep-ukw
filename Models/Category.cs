namespace SklepUKW.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
