namespace BookStoreApp_API.Models.Book
{
    public partial class BookReadOnlyDTO : BaseDTO
    {
        public int Title { get; set; }

        public string? Image { get; set; }

        public decimal? Price { get; set; }

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }
    }
}
