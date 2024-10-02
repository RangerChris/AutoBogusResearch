using AutoBogus;
using AutoBogusResearch.Tests.Fake;
using FluentAssertions;
using Xunit.Abstractions;

namespace AutoBogusResearch.Tests;

public class AutoBogusTests(ITestOutputHelper testOutputHelper)
{
    /// <summary>
    ///     Generates a basic object with all properties set
    /// </summary>
    [Fact]
    public void BasicExample()
    {
        var sut = AutoFaker.Generate<User>();
        sut.Should().NotBeNull();
        testOutputHelper.WriteLine(sut.ToString());
    }

    /// <summary>
    ///     Generates the top level object with all children
    /// </summary>
    [Fact]
    public void ComplexExample()
    {
        var fakeUser = new ProjectUserFaker();
        var fakeSprint = new SprintFaker();
        var projectFaker = new AutoFaker<Project>()
            .RuleFor(f => f.Owner, () => fakeUser)
            .RuleFor(f => f.Sprints, u => fakeSprint.Generate(u.Random.Int(1, 10)))
            .RuleFor(f => f.Members, u => fakeUser.Generate(u.Random.Int(1, 5)));
        var sut = projectFaker.Generate();
        sut.Should().NotBeNull();
        sut.Owner.Should().NotBeNull();
        sut.Sprints.Should().NotBeNullOrEmpty();
        sut.Members.Should().NotBeNullOrEmpty();
        testOutputHelper.WriteLine(sut.ToString());
    }

    /// <summary>
    ///     Demonstrates the object do not do anything on it's own
    /// </summary>
    [Fact]
    public void NoFakeTest()
    {
        var sut = new Project();
        sut.Should().NotBeNull();
        sut.Id.Should().NotBeEmpty();
        sut.Name.Should().BeNullOrEmpty();
        sut.Owner.Should().BeNull();
        sut.Sprints.Should().BeNullOrEmpty();
        sut.Members.Should().BeNullOrEmpty();
        testOutputHelper.WriteLine(sut.ToString());
    }
}