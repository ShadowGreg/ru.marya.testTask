namespace ru.marya.testTask.model.objects.abstarct;

public class City
{
    public string Name { get; } = "Москва";

    public City(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}