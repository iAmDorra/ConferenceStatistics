namespace ConferenceStatistics;

public class Conferences
{
    private readonly IEnumerable<Conference> _conferences;

    public Conferences(IEnumerable<Conference> conferences)
    {
        _conferences = conferences;
    }

    public decimal GetFemaleConfNumber(string conferenceName, int year)
    {
        return _conferences.Sum(c => c.GetFemaleConfNumber());
    }
}