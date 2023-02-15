using System.Collections.Generic;
using System.Windows.Documents;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.infoController;

public class OrderGenerator : IOrderDatabase
{
    private readonly List<Measurement> _measurements = new()
    {
        new("Петров Семён Андреевич", "ул Поляны 45б кв16",
            "89041234567", new City("Москва")),
        new("Петров Степан Андреевич", "ул Ольховая 4б кв6",
            "89046544567", new City("Москва")),
        new("Сидоров Олег Андреевич", "ул Петровая 4б кв6",
            "89996544567", new City("Самара")),
        new("Смирнов Игорь Владимирович", "ул Орловска 13 кв66",
            "89996544567", new City("Самара")),
    };


    public List<Measurement> getNewOrder()
    {
        return _measurements;
    }
}