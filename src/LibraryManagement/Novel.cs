namespace LibraryManagement;

class Novel : IBook, IBorrowable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    private string _genre;
    public string Genre { get => _genre; }

    public Novel(string title, string author, string isbn, int year, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
        _genre = genre;
    }

    void IBook.PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\". Genre: {Genre}");
    }

    public void Borrow() { }
    public void Return() { }
}