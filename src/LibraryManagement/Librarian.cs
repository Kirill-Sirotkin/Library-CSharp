namespace LibraryManagement;

class Librarian : ILibraryUser, IBookManage
{
    private Guid _id;
    public Guid Id => _id;

    private string _name;
    public string Name { get => _name; set => _name = value; }

    private Library _library;
    public Library Library => _library;

    public Librarian(string name, Library library)
    {
        _id = Guid.NewGuid();
        _name = name;
        _library = library;
    }

    public void Add(IBook book)
    {
        _library.Add(book);
    }

    public void Remove(IBook book)
    {
        _library.Remove(book);
    }

    public void Edit(IBook book, BookInfo newBook)
    {
        book.Title = newBook.Title;
        book.Author = newBook.Author;
        book.ISBN = newBook.ISBN;
        book.PublicationYear = newBook.PublicationYear;
    }
}