using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ru.marya.testTask.infoController;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;


namespace ru.marya.testTask.ViewModel.objects;

public class Measurements : ViewedCollections, INotifyPropertyChanged
{
    public ObservableCollection<Measurement> _measurements = new ObservableCollection<Measurement>();

    public event PropertyChangedEventHandler PropertyChanged = null!;

    public Measurements()
    {
        var measurements = getNewOrders();
        foreach (var measurement in measurements)
        {
            AddItem(measurement);
        }
    }

    public ObservableCollection<Measurement> GetMeasurements() => _measurements;

    public override void AddItem(CityAndEntity item)
    {
        _measurements.CollectionChanged += CollectionChanged;
        _measurements.Add((Measurement)item);
    }

    public void RemoveItem(CityAndEntity item)
    {
        _measurements.CollectionChanged += CollectionChanged;
        _measurements.Remove((Measurement)item);
    }

    public CityAndEntity GetItem(CityAndEntity item)
    {
        var measurement = item;
        _measurements.CollectionChanged += CollectionChanged;
        RemoveItem(item);
        return measurement;
    }

    public void SetDate(CityAndEntity item, DateTime date)
    {
        ((Measurement)item).Date = date;
        OnPropertyChanged("SetDate");
    }


    private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (e.NewItems?[0] is Measurement)
                    OnPropertyChanged("AddMeasurement");
                break;
            case NotifyCollectionChangedAction.Remove:
                if (e.OldItems?[0] is Measurement)
                    OnPropertyChanged("RemoveMeasurement");
                break;
            case NotifyCollectionChangedAction.Replace:
                break;
            case NotifyCollectionChangedAction.Move:
                break;
            case NotifyCollectionChangedAction.Reset:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private List<Measurement> getNewOrders()
    {
        return new OrderGenerator().getNewOrder();
    }
}