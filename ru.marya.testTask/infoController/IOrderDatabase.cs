using System.Collections.Generic;
using ru.marya.testTask.model.objects;

namespace ru.marya.testTask.infoController;

public interface IOrderDatabase
{
    public List<Measurement> getNewOrder();
}