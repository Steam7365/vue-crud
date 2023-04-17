namespace Models
{
    public class BookType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public List<Book>? Books { get; set; }
    }
}