namespace Workshops.Entities;

public sealed class Workshop
{
    public Workshop(Guid id, string name, DateTime date)
    {
        Id = id;
        Name = name;
        Date = date;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public DateTime Date { get; private set; }

}
