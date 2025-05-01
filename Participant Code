public class Participant
{
    public string Name { get; set; }
    public string CategoryCode { get; set; } // M, D, A, C, S
    public string ContactInfo { get; set; }
    public double FeePaid { get; set; }
    public bool IsValidRegistration { get; set; }

    public Participant(string name, string categoryCode, string contactInfo, double feePaid, bool isValid)
    {
        Name = name;
        CategoryCode = categoryCode.ToUpper();
        ContactInfo = contactInfo;
        FeePaid = feePaid;
        IsValidRegistration = isValid;
    }

    public virtual string GetDetails()
    {
        return $"{Name} ({CategoryCode}) - Contact: {ContactInfo}, Fee: {FeePaid:C}, Valid: {IsValidRegistration}";
    }
}
