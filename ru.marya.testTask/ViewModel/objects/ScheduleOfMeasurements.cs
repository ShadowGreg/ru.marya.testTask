using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.infoController;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;

namespace ru.marya.testTask.ViewModel.objects;

public sealed class ScheduleOfMeasurements : ViewedCollections, INotifyPropertyChanged
{
    private readonly ObservableCollection<MeasurementAbility> _scheduleMeasurements =
        new ObservableCollection<MeasurementAbility>();

    public event PropertyChangedEventHandler PropertyChanged;
    public ObservableCollection<MeasurementAbility> scheduleMeasurements { get; set; }

    public ScheduleOfMeasurements()
    {
        var abilities = getAbilitys();
        foreach (var item in abilities)
        {
            AddItem(item);
        }

        GetItemsByCity(new City("Москва"));
    }

    public void GetItemsByCity(City city)
    {
        scheduleMeasurements = new ObservableCollection<MeasurementAbility>();
        foreach (var item in _scheduleMeasurements)
        {
            if (item.getCity().ToString() != city.ToString()) continue;
            scheduleMeasurements.CollectionChanged += CollectionChanged;
            scheduleMeasurements.Add(item);
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
        OnPropertyChanged("CollectionChanged");
    }

    private List<AMeasurement> getAbilitys()
    {
        return new AbilitiesBaseGenerator().getData();
    }


    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}