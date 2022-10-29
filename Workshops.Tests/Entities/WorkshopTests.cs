using Workshops.Entities;

namespace Workshops.Tests.Entities;

public sealed class WorkshopTests
{
    [Fact]
    public void Should_Clean_Name()
    {
        var entity = new Workshop(Guid.NewGuid(), "Sample", DateTime.Now);

        Assert.Equal("Sample", entity.Name);

        entity.CleanName();

        Assert.Equal(string.Empty, entity.Name);
    }
}
