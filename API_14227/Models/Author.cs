using System.Text.Json.Serialization;

namespace API_14227.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }

        // Navigation Property
        [JsonIgnore]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
