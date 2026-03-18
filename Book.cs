public class Book: Materials
{
    public string Author{ get; set;}
    public Book(string name,  int year, string author): base(name, year)
    {
        Author = author;
    }
    public override string GetInfo()
    {
        return $"Title: {Name}, Year: {Year}, Author: {Author}";
    }
    public override string Action()
    {
        return $"Read a book {Name}";
    }
}
