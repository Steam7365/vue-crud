namespace Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public string? Author { get; set; }

        public int? BookTypeId { get; set; }
    }
}