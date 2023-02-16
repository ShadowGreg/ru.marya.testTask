using System.Collections.Generic;
using ru.marya.testTask.model;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask.infoController;

public class OrderGenerator : Data
{
    private readonly List<AMeasurement> _measurements = new List<AMeasurement>()
    {
        new Measurement("Петров Семён Андреевич", "ул Поляны 45б кв16",
            "89041234567", new City("Москва")),
        new Measurement("Петров Степан Андреевич", "ул Ольховая 4б кв6",
            "89046544567", new City("Москва")),
        new Measurement("Сидоров Олег Андреевич", "ул Петровая 4б кв6",
            "89996544567", new City("Самара")),
        new Measurement("Смирнов Игорь Владимирович", "ул Орловска 13 кв66",
            "89996544567", new City("Самара")),
    };


    public override List<AMeasurement> getData()
    {
        return _measurements;
    }
}