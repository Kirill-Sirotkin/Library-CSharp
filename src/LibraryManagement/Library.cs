namespace LibraryManagement;

class Library : IBookManage, IBookBorrow
{
    private List<Person> _users = new();
    private List<Book> _books = new();
    private List<(Book, Guid)> _borrowedBooks = new();

    public void AddUser(Person user)
    {
        _users.Add(user);
    }

    public void RemoveUser(Guid id)
    {
        _users = _users.Where(u => u.Id != id).ToList();
    }

    public void EditUser(Guid id, string newName)
    {
        Person? user = _users.Find(u => u.Id == id);
        if (user is not null) user.Name = newName;
    }

    public void Add(Book book)
    {
        if (_books.Find(b => b.ISBN == book.ISBN) is not null) return;
        _books.Add(book);
    }

    public void Remove(Book book)
    {
        _books = _books.Where(b => b.ISBN != book.ISBN).ToList();
    }

    public void Borrow(Book book, Person person)
    {
        Book? libraryBook = _books.Find(b => b.ISBN == book.ISBN);
        if (libraryBook is null) return;
        if (libraryBook is not IBorrowable) return;

        Remove(libraryBook);
        _borrowedBooks.Add((libraryBook, person.Id));
    }

    public void Return(Book book, Person person)
    {
        Book? borrowedBook = _borrowedBooks.Find(b => b.Item1.ISBN == book.ISBN).Item1;
        if (borrowedBook is null) return;

        _borrowedBooks = _borrowedBooks.Where(b => b.Item1.ISBN != book.ISBN).ToList();
        Add(borrowedBook);
    }

    public void PrintAllUsers()
    {
        Console.WriteLine("Library users:");
        foreach (Person user in _users)
        {
            Console.WriteLine($"{user.Id}: {user.GetType().Name} {user.Name}");
        }
    }

    public void PrintAllBooks()
    {
        Console.WriteLine("Books information:");
        foreach (Book book in _books)
        {
            book.PrintInfo();
        }
    }

    public void PrintAllBorrowed()
    {
        Console.WriteLine("Borrowed books:");
        foreach ((Book, Guid) book in _borrowedBooks)
        {
            Console.Write($"{book.Item2} borrowed: ");
            book.Item1.PrintInfo();
        }
    }
}