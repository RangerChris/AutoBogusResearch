using System.Text;

namespace AutoBogusResearch;

public class Tasks : BaseEntity
{
    public TaskStatusEnum Status { get; set; }

    public string? Description { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Id: {Id} Name: {Name} Status:{Status}");
        result.AppendLine($"Description: {Description}");

        return result.ToString();
    }
}