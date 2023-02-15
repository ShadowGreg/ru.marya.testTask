using System;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using ru.marya.testTask.ViewModel.objects;
using Xunit;

namespace ru.marya.testTask.tests
{
    public class MeasurementsTests
    {
        private readonly Measurements
            _measurements = new Measurements();

        [Fact]
        public void Measurements_Crate()
        {
            Assert.NotNull(_measurements);
        }

        [Fact]
        public void GetItem_Test()
        {
            var expected = new Measurement("Петров Иван Андреевич", "ул Поляны 45б кв16",
                "89041234567", new City("Москва"));

            var actual = _measurements.GetItem(expected);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SetDate_Test()
        {
            var measurement = new Measurement("Петров Иван Андреевич", "ул Поляны 45б кв16",
                "89041234567", new City("Москва"));
            var date = DateTime.Parse("12-12-2023");
            var item = _measurements.GetItem(measurement);
            _measurements.SetDate(item, date);
            _measurements.AddItem(item);
            measurement.Date = date;
            
            var actual = _measurements.GetItem(measurement);

            Assert.Equal(measurement, actual);
        }
    }
}