namespace ConferenceStatistics;

public struct Speaker
{
    private readonly string _name;
    private readonly Gender _gender;

    public Speaker(string name, Gender gender)
    {
        _name = name;
        _gender = gender;
    }

    public bool IsFemale()
    {
        return _gender == Gender.Female;
    }
}