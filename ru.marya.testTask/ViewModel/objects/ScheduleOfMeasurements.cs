using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.infoController;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.ViewModel.objects;

public class ScheduleOfMeasurements : ViewedCollections, INotifyPropertyChanged
{
    private readonly ObservableCollection<MeasurementAbility> _scheduleMeasurements =
        new ObservableCollection<MeasurementAbility>();

    public event PropertyChangedEventHandler PropertyChanged;

    public ScheduleOfMeasurements()
    {
        var abilities = getAbilitys();
        foreach (var item in abilities)
        {
            AddItem(item);
        }
    }

    public ObservableCollection<MeasurementAbility> GetScheduleMeasurements() => _scheduleMeasurements;

    public override void AddItem(AMeasurement item)
    {
        _scheduleMeasurements.CollectionChanged += CollectionChanged;
        _scheduleMeasurements.Add((MeasurementAbility)item);
    }

    private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private List<AMeasurement> getAbilitys()
    {
        return new AbilitiesBaseGenerator().getData();
    }


    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}