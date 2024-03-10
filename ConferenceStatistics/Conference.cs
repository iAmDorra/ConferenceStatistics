namespace ConferenceStatistics;

public struct Conference
{
    private readonly string _title;
    private readonly int _year;
    private readonly List<Talk> _talks;

    public Conference(string title, int year, List<Talk> talks)
    {
        _title = title;
        _year = year;
        _talks = talks;
    }

    public decimal GetFemaleConfNumber()
    {
        return _talks.Count(t=> t.HasFemaleSpeaker());
    }
}