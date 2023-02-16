using System;
using ru.marya.testTask.model.objects;
using ru.marya.testTask.model.objects.abstarct;
using Xunit;

namespace ru.marya.testTask.tests
{
    public class MeasurementTests
    {
        private readonly Measurement
            _measurement = new Measurement("Test Test Test", "Test", "Test", new City("Москва"));

        [Fact]
        public void Measurement_Crate()
        {
            Assert.NotNull(_measurement);
        }

        [Fact]
        public void Measurement_Get_Fields()
        {
            Assert.NotNull(_measurement.MeasureId);
            Assert.NotNull(_measurement.FullName);
            Assert.NotNull(_measurement.Address);
            Assert.NotNull(_measurement.PhoneNumber);
            Assert.NotNull(_measurement.Date);
            Assert.NotNull(_measurement.getCity());
        }

        [Fact]
        public void Measurement_Set_Date()
        {
            var expectedDate = DateTime.Now;
            _measurement.Date = expectedDate;

            var actualDate = _measurement.Date;

            Assert.Equal(expectedDate, actualDate);
        }

        [Fact]
        public void Measurement_Properties_Changed_Test()
        {
            var changedPropertyDate = DateTime.Parse("12-12-2215").ToString();
            _measurement.PropertyChanged += (sender, args) => changedPropertyDate = args.PropertyName;

            _measurement.Date = DateTime.Now;
            const string expected = "MeasurementAddDate";

            Assert.Equal(expected, changedPropertyDate);
        }
    }
}