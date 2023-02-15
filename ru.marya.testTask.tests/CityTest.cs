using ru.marya.testTask.model.objects.abstarct;
using Xunit;

namespace ru.marya.testTask.tests;

public class CityTest
{
    [Fact]
    public void City_Crate()
    {
        var city = new City("Москва");

        const string expected = "Москва";

        Assert.Equal(expected, city.Name);
    }
}