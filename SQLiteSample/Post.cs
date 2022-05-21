using System.ComponentModel.DataAnnotations;

namespace SQLiteSample
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Conentent { get; set; }
        public string Author { get; set; }
    }
}
