using System.Dynamic;

public abstract class Materials
{
    
    public string Name{ get; set;}
    public int _year;
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value < 1450|| value > 2026)
            {
                _year = 2024;
            }
            else
            {
                _year = value;
            }
        }
    }
    public Materials(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public abstract string GetInfo();
    public abstract string Action();
}