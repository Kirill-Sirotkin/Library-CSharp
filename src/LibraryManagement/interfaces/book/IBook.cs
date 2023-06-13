namespace LibraryManagement;

interface IBook
{
    string Title { get; set; }
    string Author { get; set; }
    string ISBN { get; set; }
    int PublicationYear { get; set; }

    void PrintInfo()
    {
        Console.WriteLine($"Book Info: {Title}, {Author} ({PublicationYear}). ISBN:\"{ISBN}\"");
    }
}