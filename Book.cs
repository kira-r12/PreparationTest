public class Book: Materials
{
    public Book(string name,  int year): base(name, year)
    {
        
    }
    public override string GetInfo()
    {
        return $"Title: {Name}, Year: {Year}";
    }
}
