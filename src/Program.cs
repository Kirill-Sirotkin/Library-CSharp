using LibraryManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        // Making library
        Library library = new();

        // Making books
        Comic comic = new("SuperMan", "John", "1", 2023, "Steven");
        Novel novel = new("Knight", "Anna", "2", 2022, "Adventure");
        TextBook textBook = new("Programming", "Rich", "3", 1999, 500);
        ResearchPaper researchPaper = new("Study", "Brian", "4", 2019, 12);

        // Making users
        Librarian librarian = new("Lisa", library);
        Customer customer = new("Jack", library);

        library.AddUser(librarian);
        library.AddUser(customer);

        // Adding books. It is expected to be done through Librarian class methods
        librarian.Add(comic);
        librarian.Add(novel);
        librarian.Add(textBook);
        librarian.Add(researchPaper);

        // Display what we have so far:
        library.PrintAllUsers();
        library.PrintAllBooks();

        // Borrowing and returning books. It is expected to be done through Customer class methods
        customer.Borrow(comic);
        customer.Borrow(researchPaper); // This line will not do anything, because research paper is not borrowable

        // Should display only comic as a borrowed book
        library.PrintAllBooks();
        library.PrintAllBorrowed();
    }
}