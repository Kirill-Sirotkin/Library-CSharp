namespace LibraryManagement;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\"");
    }
}