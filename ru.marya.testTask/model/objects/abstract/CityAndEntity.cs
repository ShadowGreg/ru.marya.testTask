using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ru.marya.testTask.model.objects.abstarct;

public abstract class CityAndEntity
{
    protected City CityName;

    protected CityAndEntity(City cityName)
    {
        CityName = cityName;
    }

    public abstract City getCity();
}