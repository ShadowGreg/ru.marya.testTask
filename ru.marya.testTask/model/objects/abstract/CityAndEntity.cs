using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ru.marya.testTask.model.objects.abstarct;

public abstract class CityAndEntity
{
    protected City _name;

    protected CityAndEntity(City name)
    {
        _name = name;
    }

    public abstract City getCity();
}