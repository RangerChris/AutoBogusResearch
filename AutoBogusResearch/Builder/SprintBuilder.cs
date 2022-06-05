namespace AutoBogusResearch.Builder;

public class SprintBuilder
{
    private readonly Sprint _sprint = new();

    public Sprint Build()
    {
        return _sprint;
    }

    public SprintBuilder WithDuration(DateTime start, DateTime end)
    {
        _sprint.Start = start;
        _sprint.End = end;
        return this;
    }

    public SprintBuilder StoryPoints(int points)
    {
        _sprint.StoryPoints = points;
        return this;
    }

    public SprintBuilder WithName(string name)
    {
        _sprint.Name = name;
        return this;
    }

    public SprintBuilder AddTask(string name, string? description)
    {
        var newTask = new Tasks
        {
            Name = name,
            Description = description
        };
        _sprint.Tasks?.Add(newTask);
        return this;
    }
}