namespace LibraryManagement;

class Comic : IBook, IBorrowable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    private string _artist;
    public string Artist { get => _artist; }

    public Comic(string title, string author, string isbn, int year, string artist)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
        _artist = artist;
    }

    void IBook.PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\". Artist: {Artist}");
    }

    public void Borrow() { }
    public void Return() { }
}