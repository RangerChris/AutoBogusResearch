using AutoBogusResearch.Builder;
using FluentAssertions;

namespace AutoBogusResearch.Tests
{
    public class BuilderTests
    {
        /// <summary>
        ///     Demonstrates how we would do basic value assignments of our object
        /// </summary>
        [Fact]
        public void OldSchoolSprintTest()
        {
            var sprint = new Sprint
            {
                Name = "Old school sprint test",
                Start = DateTime.Now,
                End = DateTime.Now.AddDays(7),
                StoryPoints = 10
            };
            sprint.Tasks?.Add(new Tasks
            {
                Name = "Here is the first task to do",
                Description = "This is the description"
            });

            sprint.Should().NotBeNull();
            sprint.StoryPoints.Should().Be(10);
        }

        /// <summary>
        ///     Demonstrates how we can make more readable code, using object builders
        /// </summary>
        [Fact]
        public void BuildSprintTest()
        {
            var sprint = new SprintBuilder()
                         .WithName("Test sprint")
                         .WithDuration(DateTime.Now, DateTime.Now.AddDays(7))
                         .AddTask("Make test fail", "This is the first step when doing TDD")
                         .AddTask("Make test succeed (go green)", "You now know your code is working according to your test")
                         .AddTask("Refactor", "Very important step to make your code as easy to read as possible")
                         .StoryPoints(21)
                         .Build();

            sprint.Name.Should().Be("Test sprint");
            sprint.StoryPoints.Should().Be(21);
            sprint.Tasks.Should().HaveCount(3);
        }
    }
}
