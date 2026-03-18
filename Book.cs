public class Book
{
    public string Name {get; set;}
    public int YearOfPublication {get; set;}
    public Book(string name, int year)
    {
        Name = name;
        YearOfPublication = year;
    }
    public string GetInfo()
    {
        return $"Title: {Name}, Year: {YearOfPublication}";
    }
}
