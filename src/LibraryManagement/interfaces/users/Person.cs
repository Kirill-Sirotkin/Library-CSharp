namespace LibraryManagement;

class Person
{
    public string Name { get; set; }
    public Guid Id { get; }

    public Person(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
}