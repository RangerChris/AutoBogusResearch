using AutoBogus;

namespace AutoBogusResearch.Tests.Fake;

public class ProjectUserFaker : AutoFaker<User>
{
    public ProjectUserFaker()
    {
        RuleFor(f => f.Name, v => v.Person.FullName);
        RuleFor(f => f.Email, v => v.Person.Email);
    }
}