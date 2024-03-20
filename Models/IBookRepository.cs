namespace Mission11_Peterson.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
