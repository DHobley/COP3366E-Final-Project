public class CulinaryParticipant : Participant
{
    public string CuisineType { get; set; }
    public int SampleServingSizes { get; set; }

    public CulinaryParticipant(string name, string contactInfo, double feePaid, bool isValid,
                               string cuisineType, int servings)
        : base(name, "C", contactInfo, feePaid, isValid)
    {
        CuisineType = cuisineType;
        SampleServingSizes = servings;
    }
}
