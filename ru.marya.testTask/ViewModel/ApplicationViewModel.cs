using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask.ViewModel;

public sealed class ApplicationViewModel : INotifyPropertyChanged
{
    public Measurements measurement;
    public ScheduleOfMeasurements schedule;
    public ObservableCollection<Measurement> Measurements { get; }
    public ObservableCollection<MeasurementAbility> Schedule { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    public ApplicationViewModel()
    {
        measurement = new Measurements();
        schedule = new ScheduleOfMeasurements();
        Measurements = measurement.GetMeasurements();
        Schedule = schedule.scheduleMeasurements;
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}