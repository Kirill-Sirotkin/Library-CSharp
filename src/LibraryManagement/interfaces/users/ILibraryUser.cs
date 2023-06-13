namespace LibraryManagement;

interface ILibraryUser : IIdentifier, IPerson
{
    Library Library { get; }
}