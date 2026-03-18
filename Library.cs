
public class Library
{
    List<Book> listLibrary = new();
    public void AddBook(Book b)
    {
        listLibrary.Add(b);
    }
    public void ShowMaterial()
    {
        foreach (Book book in listLibrary)
        {
            Console.WriteLine($"Materials: {book.GetInfo()}");
        }
    }
}