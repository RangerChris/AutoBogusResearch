using System.Text;

namespace AutoBogusResearch;

public class Sprint : BaseEntity
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public double StoryPoints { get; set; }

    public List<Tasks>? Tasks { get; } = [];

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"=Sprint= Id: {Id} Name: {Name} Story points: {StoryPoints}");
        result.AppendLine($"From: {Start} to {End}");

        if (Tasks != null)
            foreach (var task in Tasks)
                result.AppendLine($"Task: {task}");

        return result.ToString();
    }
}