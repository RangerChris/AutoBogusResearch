using System.Text;

namespace AutoBogusResearch;

public class User : BaseEntity
{
    public UserType UserType { get; }

    public IEnumerable<Project>? Projects { get; }

    public string? Email { get; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine(
            $"=User= Id: {Id} Name: {Name} Email:{Email} Type: {UserType} Number of projects: {Projects?.Count()}");

        return result.ToString();
    }
}