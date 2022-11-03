using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.Models
{
    public class BookManagementSystemContext : DbContext
    {
        public BookManagementSystemContext(DbContextOptions<BookManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
