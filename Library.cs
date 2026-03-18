
public class Library
{
    List<Materials> listLibrary = new();

    public void Add(Materials m)
    {
        listLibrary.Add(m);

    }
    public void ShowMaterial()
    {
        Console.WriteLine("MATERIALS:");

        foreach (Materials material in listLibrary)
        {
            Console.WriteLine($"{material.GetInfo()}");
        }
    }
}