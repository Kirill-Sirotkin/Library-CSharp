namespace LibraryManagement;

interface IBookBorrow
{
    void Borrow(Book book, Person person);
    void Return(Book book, Person person);
}