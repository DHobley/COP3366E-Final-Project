public class DanceParticipant : Participant
{
    public string DanceStyle { get; set; }
    public string PreferredStageSize { get; set; }
    public string ChoreographerInfo { get; set; }

    public DanceParticipant(string name, string contactInfo, double fee, bool valid, string style, string stage, string choreographer)
        : base(name, "D", contactInfo, fee, valid)
    {
        DanceStyle = style;
        PreferredStageSize = stage;
        ChoreographerInfo = choreographer;
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $" | Dance Style: {DanceStyle}, Stage Size: {PreferredStageSize}, Choreographer: {ChoreographerInfo}";
    }
}
