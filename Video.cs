public class Video: Materials
{
    public int TimeLine{get; set;}
    public Video(string name, int year, int time): base(name, year)
    {
        TimeLine = time;
    }

    public override string GetInfo()
    {
        return $"Video: {Name} - {Year},  time: {TimeLine}";
    }
    public override string Action()
    {
        return $"Відтворюю відео {Name} тривалістю {TimeLine} хв...";
    }
}