using System.Collections.Generic;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask.infoController;

public abstract class Data
{
    public abstract List<AMeasurement> getData();
}