using System.Text.Json.Serialization;

namespace API_14227.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }

        // Navigation Property
        [JsonIgnore]
        public Author Author { get; set; }
    }
}
