public class MusicParticipant : Participant
{
    public string InstrumentType { get; set; }
    public int NumberOfBandMembers { get; set; }
    public int SetupTimeRequired { get; set; } // in minutes

    public MusicParticipant(string name, string contactInfo, double feePaid, bool isValid,
                            string instrumentType, int bandMembers, int setupTime)
        : base(name, "M", contactInfo, feePaid, isValid)
    {
        InstrumentType = instrumentType;
        NumberOfBandMembers = bandMembers;
        SetupTimeRequired = setupTime;
    }
}
