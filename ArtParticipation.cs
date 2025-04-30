public class ArtParticipant : Participant
{
    public string ArtMedium { get; set; }
    public string DisplayDimensions { get; set; }

    public ArtParticipant(string name, string contactInfo, double feePaid, bool isValid,
                          string medium, string dimensions)
        : base(name, "A", contactInfo, feePaid, isValid)
    {
        ArtMedium = medium;
        DisplayDimensions = dimensions;
    }
}
