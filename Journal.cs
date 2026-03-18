public class Journal: Materials
{
    public int Number{ get;  set;  }
    public Journal(string name, int year, int number): base(name, year)
    {
        Number = number;
    }

    public override string GetInfo()
    {
        return $"Journal: {Name} - {Year} №{Number}";
    }
}