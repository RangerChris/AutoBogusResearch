using AutoBogus;

namespace AutoBogusResearch.Tests.Fake;

public class SprintFaker : AutoFaker<Sprint>
{
    public SprintFaker()
    {
        var fakeTask = new TaskFaker();
        RuleFor(f => f.Name, v => v.Company.CatchPhrase());
        RuleFor(f => f.StoryPoints, v => v.Random.Int(5, 50));
        RuleFor(f => f.Tasks, fakeTask.Generate(3));
    }
}