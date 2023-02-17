using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.model.objects.abstarct;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask.model.objects;

public sealed class Measurement : AMeasurement, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private DateTime _date;
    public string MeasureId { get; }

    public string FullName { get; }

    public string CityName => base.CityName.ToString();

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

    public Measurement(string fullName, string address, string phoneNumber, City cityName) : base(cityName)
    {
        MeasureId = Guid.NewGuid().ToString("N").Substring(0, 6);
        FullName = fullName;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override City getCity()
    {
        return base.CityName;
    }
}