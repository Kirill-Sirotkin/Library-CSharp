namespace LibraryManagement;

class Comic : Book, IBorrowable
{
    private string _artist;
    public string Artist { get => _artist; }

    public Comic(string title, string author, string isbn, int year, string artist) : base(title, author, isbn, year)
    {
        _artist = artist;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\". Artist: {Artist}");
    }

    public void Borrow() { }
    public void Return() { }
}