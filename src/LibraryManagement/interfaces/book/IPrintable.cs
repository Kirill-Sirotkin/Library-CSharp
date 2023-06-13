namespace LibraryManagement;

interface IPrintable
{
    int MaxPages { get; }

    void PrintPages(int startPage, int endPage);
}