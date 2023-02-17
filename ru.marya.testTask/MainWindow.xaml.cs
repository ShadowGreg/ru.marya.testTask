﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using ru.marya.testTask.ViewModel.objects;

namespace ru.marya.testTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ScheduleOfMeasurements shedule = new ScheduleOfMeasurements();

        public MainWindow()
        {
            InitializeComponent();
            GetSchedule();
            Schedule.ItemsSource = shedule.scheduleMeasurements;
        }

        private void DataGridMeasurements_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var temp = (Measurement)DataGridMeasurements.SelectedItem;
            GetSchedule(temp.getCity().ToString());
        }

        private void GetSchedule(string cityName = "Москва")
        {
            shedule.GetItemsByCity(new City(cityName));
        }
    }
}