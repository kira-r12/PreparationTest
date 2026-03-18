public abstract class Materials
{
    public string Name{ get; set;}
    public int Year {get;  set;}
    public Materials(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public abstract string GetInfo();
}