using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.ViewModel;

namespace ru.marya.testTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationViewModel aplication;
        public MainWindow()
        {
            aplication = new ApplicationViewModel();
            InitializeComponent();
            
            DataGridMeasurements.ItemsSource = aplication.Measurements;
            
        }

        private void DataGridMeasurements_OnMouseDoubleClick(object sender, RoutedEventArgs routedEventArgs)
        {
            var city = (Measurement)DataGridMeasurements.CurrentItem;
            aplication.schedule.GetItemsByCity(city.getCity());
            LabelCityName.Content= city.CityName;
            Schedule.ItemsSource = aplication.schedule.scheduleMeasurements;
        }
    }
}