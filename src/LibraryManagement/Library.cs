namespace LibraryManagement;

class Library : IBookManage, IBookBorrow
{
    private List<ILibraryUser> _users = new();
    private List<IBook> _books = new();
    private List<(IBook, Guid)> _borrowedBooks = new();

    public void AddUser(ILibraryUser user)
    {
        _users.Add(user);
    }

    public void RemoveUser(Guid id)
    {
        _users = _users.Where(u => u.Id != id).ToList();
    }

    public void EditUser(Guid id, string newName)
    {
        ILibraryUser? user = _users.Find(u => u.Id == id);
        if (user is not null) user.Name = newName;
    }

    public void Add(IBook book)
    {
        if (_books.Find(b => b.ISBN == book.ISBN) is not null) return;
        _books.Add(book);
    }

    public void Remove(IBook book)
    {
        _books = _books.Where(b => b.ISBN != book.ISBN).ToList();
    }

    public void Borrow(IBook book, IIdentifier id)
    {
        IBook? libraryBook = _books.Find(b => b.ISBN == book.ISBN);
        if (libraryBook is null) return;
        if (libraryBook is not IBorrowable) return;

        Remove(libraryBook);
        _borrowedBooks.Add((libraryBook, id.Id));
    }

    public void Return(IBook book, IIdentifier id)
    {
        IBook? borrowedBook = _borrowedBooks.Find(b => b.Item1.ISBN == book.ISBN).Item1;
        if (borrowedBook is null) return;

        _borrowedBooks = _borrowedBooks.Where(b => b.Item1.ISBN != book.ISBN).ToList();
        Add(borrowedBook);
    }

    public void PrintAllUsers()
    {
        Console.WriteLine("Library users:");
        foreach (ILibraryUser user in _users)
        {
            Console.WriteLine($"{user.Id}: {user.GetType().Name} {user.Name}");
        }
    }

    public void PrintAllBooks()
    {
        Console.WriteLine("Books information:");
        foreach (IBook book in _books)
        {
            book.PrintInfo();
        }
    }

    public void PrintAllBorrowed()
    {
        Console.WriteLine("Borrowed books:");
        foreach ((IBook, Guid) book in _borrowedBooks)
        {
            Console.Write($"{book.Item2} borrowed: ");
            book.Item1.PrintInfo();
        }
    }
}