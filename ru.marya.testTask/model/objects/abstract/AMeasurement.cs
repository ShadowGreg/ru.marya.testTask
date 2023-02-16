using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.ViewModel.objects;

public abstract class AMeasurement
{
    protected readonly City CityName;

    protected AMeasurement(City cityName)
    {
        CityName = cityName;
    }

    public abstract City getCity();
}