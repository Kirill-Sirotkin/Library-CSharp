namespace LibraryManagement;

class Customer : ILibraryUser, IBookBorrow
{
    private Guid _id;
    public Guid Id => _id;

    private string _name;
    public string Name { get => _name; set => _name = value; }

    private Library _library;
    public Library Library => _library;

    public Customer(string name, Library library)
    {
        _id = Guid.NewGuid();
        _name = name;
        _library = library;
    }

    public void Borrow(IBook book, IIdentifier? id = null)
    {
        _library.Borrow(book, this);
    }

    public void Return(IBook book, IIdentifier? id = null)
    {
        _library.Return(book, this);
    }
}