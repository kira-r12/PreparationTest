
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
    public void PerformActions()
    {
        foreach (Materials mat in listLibrary)
        {
            Console.WriteLine($"{mat.Action()}");
        }
    }
    public void SearchByYear(int year)
    {
        foreach (Materials filtrYear in listLibrary)
        {
            if (filtrYear.Year == year)
            {
                Console.WriteLine(filtrYear.GetInfo());
            }
        }
    }

}