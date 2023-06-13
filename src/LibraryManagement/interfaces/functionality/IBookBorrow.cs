namespace LibraryManagement;

interface IBookBorrow
{
    void Borrow(IBook book, IIdentifier id);
    void Return(IBook book, IIdentifier id);
}