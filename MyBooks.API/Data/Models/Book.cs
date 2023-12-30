namespace MyBooks.API.Data.Models
{
    public class Book
    {
        //all properties that will be as table column in db
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; } //? make the property optional
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
