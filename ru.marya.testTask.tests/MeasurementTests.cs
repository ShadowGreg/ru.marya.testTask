using System;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using Xunit;

namespace ru.marya.testTask.tests
{
    public class MeasurementTests
    {
        private readonly Measurement
            measurement = new Measurement("Test Test Test", "Test", "Test", new City("Москва"));

        [Fact]
        public void Measurement_Crate()
        {
            Assert.NotNull(measurement);
        }

        [Fact]
        public void Measurement_Get_Fields()
        {
            Assert.NotNull(measurement.MeasureId);
            Assert.NotNull(measurement.FullName);
            Assert.NotNull(measurement.Address);
            Assert.NotNull(measurement.PhoneNumber);
            Assert.NotNull(measurement.Date);
            Assert.NotNull(measurement.getCity());
        }

        [Fact]
        public void Measurement_Set_Date()
        {
            var expectedDate = DateTime.Now;
            measurement.Date = expectedDate;

            var actualDate = measurement.Date;

            Assert.Equal(expectedDate, actualDate);
        }

        [Fact]
        public void Measurement_Properties_Changed_Test()
        {
            var changedPropertyDate = DateTime.Parse("12-12-2215").ToString();
            measurement.PropertyChanged += (sender, args) => changedPropertyDate = args.PropertyName;

            measurement.Date = DateTime.Now;
            const string expected = "MeasurementAddDate";

            Assert.Equal(expected, changedPropertyDate);
        }
    }
}