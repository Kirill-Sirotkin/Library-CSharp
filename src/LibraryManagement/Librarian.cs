namespace LibraryManagement;

class Librarian : Person, IBookManage
{
    private Library _library;
    public Library Library => _library;

    public Librarian(string name, Library library) : base(name)
    {
        _library = library;
    }

    public void Add(Book book)
    {
        _library.Add(book);
    }

    public void Remove(Book book)
    {
        _library.Remove(book);
    }

    public void Edit(Book book, Book newBook)
    {
        book.Title = newBook.Title;
        book.Author = newBook.Author;
        book.ISBN = newBook.ISBN;
        book.PublicationYear = newBook.PublicationYear;
    }
}