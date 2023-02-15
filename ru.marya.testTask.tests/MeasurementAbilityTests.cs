using System;
using ru.marya.testTask.model.objects.abstarct;
using Xunit;

namespace ru.marya.testTask.tests
{
    public class MeasurementAbilityTest
    {
        private static readonly int ability = 4;

        private readonly MeasurementAbility measurementAbility =
            new MeasurementAbility(ability, DateTime.Parse("12-12-2023"), new City("Москва"));

        [Fact]
        public void Measurement_Ability_Crate()
        {
            Assert.NotNull(measurementAbility);
            Assert.NotNull(measurementAbility.getCity());
        }

        [Fact]
        public void Measurement_Ability_Get_Date()
        {
            const string expected = "12.12.2023 0:00:00";

            Assert.Equal(expected, measurementAbility.Date.ToString());
        }

        [Fact]
        public void Measurement_Ability_Get_Ability()
        {
            const int expected = 4;

            Assert.Equal(expected, measurementAbility.MeasureAbility);
        }

        [Fact]
        public void Measurement_Ability_Booking_Ability_Test()
        {
            measurementAbility.BookingAbility();

            const int expected = 3;

            Assert.Equal(expected, measurementAbility.MeasureAbility);
        }

        [Fact]
        public void Measurement_Ability_Properties_Changed_Test()
        {
            string changedPropertyAbility = null;
            measurementAbility.PropertyChanged += (_, args) => changedPropertyAbility = args.PropertyName;

            measurementAbility.BookingAbility();
            var expected = "MeasureAbilityChange";

            Assert.Equal(expected, changedPropertyAbility);
        }
    }
}