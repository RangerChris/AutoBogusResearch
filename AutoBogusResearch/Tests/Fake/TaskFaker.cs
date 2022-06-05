using AutoBogus;

namespace AutoBogusResearch.Tests.Fake;

public class TaskFaker : AutoFaker<Tasks>
{
    public TaskFaker()
    {
        RuleFor(f => f.Name, v => v.Company.CatchPhrase());
        RuleFor(f => f.Description, v => v.Lorem.Paragraph());
    }
}