using System;
using System.Collections.Generic;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask.infoController;

internal class AbilitiesBaseGenerator : Data
{
    private readonly List<AMeasurement> _abilities = new List<AMeasurement>()
    {
        new MeasurementAbility(14, DateTime.Parse("12-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("13-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("14-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("15-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("16-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("17-02-2023"), new City("Москва")),
        new MeasurementAbility(12, DateTime.Parse("18-02-2023"), new City("Москва")),
        new MeasurementAbility(4, DateTime.Parse("12-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("13-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("14-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("15-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("16-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("17-02-2023"), new City("Самара")),
        new MeasurementAbility(2, DateTime.Parse("18-02-2023"), new City("Самара")),
    };

    public override List<AMeasurement> getData()
    {
        return _abilities;
    }
}