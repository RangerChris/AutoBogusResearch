using System.Text;

namespace AutoBogusResearch;

public class Project : BaseEntity
{
    public Project()
    {
        Id = Guid.NewGuid();
    }

    public IEnumerable<Sprint>? Sprints { get; set; }

    public User? Owner { get; set; }

    public IEnumerable<User> Members { get; set; } = [];

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"=Project= Id: {Id} Name: {Name}");
        result.AppendLine($"Owner: {Owner}");
        result.AppendLine($"Members: {Members.Count()}");

        foreach (var member in Members) result.AppendLine($"Member: {member}");

        if (Sprints != null)
            foreach (var sprint in Sprints)
                result.AppendLine(sprint.ToString());

        return result.ToString();
    }
}