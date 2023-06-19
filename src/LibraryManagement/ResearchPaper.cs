namespace LibraryManagement;

class ResearchPaper : Book, IPrintable
{
    private int _maxPages;
    public int MaxPages => _maxPages;

    public ResearchPaper(string title, string author, string isbn, int year, int maxPages) : base(title, author, isbn, year)
    {
        _maxPages = maxPages;
    }

    public void PrintPages(int startPage, int endPage)
    {
        if (startPage > endPage) return;
        if (startPage < 1 || endPage > MaxPages) return;
        Console.WriteLine($"Printing ResearchPaper pages from {startPage} to {endPage}");
    }
}