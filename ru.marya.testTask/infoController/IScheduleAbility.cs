using System.Collections.Generic;
using ru.marya.testTask.model.objects;

namespace ru.marya.testTask.infoController;

public interface IScheduleAbility
{
    public List<MeasurementAbility> getAbilitys();
}