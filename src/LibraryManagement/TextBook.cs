namespace LibraryManagement;

class TextBook : Book, IBorrowable, IPrintable
{
    private int _maxPages;
    public int MaxPages => _maxPages;

    public TextBook(string title, string author, string isbn, int year, int maxPages) : base(title, author, isbn, year)
    {
        _maxPages = maxPages;
    }

    public void PrintPages(int startPage, int endPage)
    {
        if (startPage > endPage) return;
        if (startPage < 1 || endPage > MaxPages) return;
        Console.WriteLine($"Printing TextBook pages from {startPage} to {endPage}");
    }

    public void Borrow() { }
    public void Return() { }
}