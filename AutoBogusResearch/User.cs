using System.Text;

namespace AutoBogusResearch;

public class User : BaseEntity
{
    public UserTypeEnum UserType { get; set; }

    public IEnumerable<Project>? Projects { get; set; }

    public string? Email { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine(
            $"=User= Id: {Id} Name: {Name} Email:{Email} Type: {UserType} Number of projects: {Projects?.Count()}");

        return result.ToString();
    }
}