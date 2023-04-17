namespace Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public string? Author { get; set; }

        public int? BookTypeId { get; set; }
    }
}