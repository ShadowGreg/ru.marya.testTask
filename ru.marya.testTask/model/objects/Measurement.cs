using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.model.objects;

public sealed class Measurement : CityAndEntity, INotifyPropertyChanged, IMeasurement
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private DateTime _date;
    public int MeasureId { get; }

    public string FullName { get; }

    public string Address { get; }

    public string PhoneNumber { get; }

    public DateTime Date
    {
        get => _date;
        set
        {
            _date = value;
            OnPropertyChanged("MeasurementAddDate");
        }
    }

    public Measurement(string fullName, string address, string phoneNumber, City name) : base(name)
    {
        MeasureId = new Random().Next(100_000, 999_999);
        FullName = fullName;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public override City getCity()
    {
        return _name;
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}