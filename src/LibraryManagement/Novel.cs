namespace LibraryManagement;

class Novel : Book, IBorrowable
{
    private string _genre;
    public string Genre { get => _genre; }

    public Novel(string title, string author, string isbn, int year, string genre) : base(title, author, isbn, year)
    {
        _genre = genre;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\". Genre: {Genre}");
    }

    public void Borrow() { }
    public void Return() { }
}