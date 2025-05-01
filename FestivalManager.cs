using System.Collections.Generic;
using System.Linq;

public class FestivalManager
{
    public string FestivalName { get; set; }
    public int Year { get; set; }
    public List<Participant> Participants { get; set; } = new List<Participant>();

    public FestivalManager(string name, int year)
    {
        FestivalName = name;
        Year = year;
    }

    public void AddParticipant(Participant p)
    {
        Participants.Add(p);
    }

    public Participant FindParticipant(string name)
    {
        return Participants.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
    }

    public double CalculateTotalFees()
    {
        return Participants.Sum(p => p.FeePaid);
    }

    public string DisplayAllParticipants()
    {
        return string.Join("\n", Participants.Select(p => p.GetDetails()));
    }
}
