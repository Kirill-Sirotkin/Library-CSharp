namespace LibraryManagement;

struct BookInfo
{
    public string Title;
    public string Author;
    public string ISBN;
    public int PublicationYear;

    public BookInfo(string title, string author, string isbn, int year)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
    }
}