using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.model.objects;

public sealed class MeasurementAbility : CityAndEntity, INotifyPropertyChanged, IMeasurement
{
    public event PropertyChangedEventHandler PropertyChanged = null!;

    public DateTime Date { get; }

    public int MeasureAbility { get; private set; }

    public MeasurementAbility(int measureAbility, DateTime date, City cityName) : base(cityName)
    {
        MeasureAbility = measureAbility;
        Date = date;
    }

    public void BookingAbility()
    {
        if (MeasureAbility <= 0) return;
        MeasureAbility--;
        OnPropertyChanged("MeasureAbilityChange");
    }

    public override City getCity()
    {
        return CityName;
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}