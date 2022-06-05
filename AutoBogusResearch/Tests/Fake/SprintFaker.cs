using AutoBogus;

namespace AutoBogusResearch.Tests.Fake;

public class SprintFaker : AutoFaker<Sprint>
{
    public SprintFaker()
    {
        var fakeTask = new TaskFaker();
        RuleFor(f => f.Name, v => v.Company.CatchPhrase());
        RuleFor(f => f.StoryPoints, v => v.Random.Int(5, 50));
        //RuleFor(f => f.Start, v => v.Date.BetweenOffset(DateTimeOffset.Now, DateTimeOffset.Now.AddDays(30)));
        //RuleFor(f => f.End, (r, u) => u.Start.AddDays(14));
        RuleFor(f => f.Tasks, fakeTask.Generate(3));
    }
}