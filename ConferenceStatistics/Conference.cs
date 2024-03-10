namespace ConferenceStatistics;

public struct Conference
{
    private readonly string _title;
    private readonly int _year;

    public Conference(string title, int year)
    {
        _title = title;
        _year = year;
    }
}