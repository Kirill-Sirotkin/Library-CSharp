namespace LibraryManagement;

class Customer : Person, IBookBorrow
{
    private Library _library;
    public Library Library => _library;

    public Customer(string name, Library library) : base(name)
    {
        _library = library;
    }

    public void Borrow(Book book, Person? person = null)
    {
        _library.Borrow(book, this);
    }

    public void Return(Book book, Person? person = null)
    {
        _library.Return(book, this);
    }
}