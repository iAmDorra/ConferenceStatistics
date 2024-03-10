namespace ConferenceStatistics;

public class Talk
{
    private readonly Speaker _speaker;

    public Talk(Speaker speaker)
    {
        _speaker = speaker;
    }

    public bool HasFemaleSpeaker()
    {
        return this._speaker.IsFemale();
    }
}