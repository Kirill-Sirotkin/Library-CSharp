namespace LibraryManagement;

class ResearchPaper : IBook, IPrintable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    private int _maxPages;
    public int MaxPages => _maxPages;

    public ResearchPaper(string title, string author, string isbn, int year, int maxPages)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
        _maxPages = maxPages;
    }

    public void PrintPages(int startPage, int endPage)
    {
        if (startPage > endPage) return;
        if (startPage < 1 || endPage > MaxPages) return;
        Console.WriteLine($"Printing ResearchPaper pages from {startPage} to {endPage}");
    }
}