using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models
{
    public class Book
    {
        //ID, Tittle, Author, Publisher, Genre, Price
        [Key]
        public int BookId { get; set; }
        public string? Tittle { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Genre { get; set; }
        public int Price { get; set; }
    }
}
