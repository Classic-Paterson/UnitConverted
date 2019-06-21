using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTests
{
    [TestClass]
    public class TemperatureTests
    {
        [TestMethod]
        public void convertThemUnitsKelvinToCelsius()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Kelvin", UnitShort = "K", UnitType = "Degrees" };
            Unit outputUnit = new Unit { UnitLong = "Celsius", UnitShort = "C", UnitType = "Temperature" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 293.1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsKelvinToFahrenheit()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Kelvin", UnitShort = "K", UnitType = "Degrees" };
            Unit outputUnit = new Unit { UnitLong = "Fahrenheit", UnitShort = "F", UnitType = "Temperature" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = -423.66999999999996;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsCelsiusToKelvin()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Celsius", UnitShort = "C", UnitType = "Temperature" };
            Unit outputUnit = new Unit { UnitLong = "Kelvin", UnitShort = "K", UnitType = "Degrees" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 293.1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsCelsiusToFahrenheit()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Celsius", UnitShort = "C", UnitType = "Temperature" };
            Unit outputUnit = new Unit { UnitLong = "Fahrenheit", UnitShort = "F", UnitType = "Temperature" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 68;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsFahrenheitToKelvin()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Fahrenheit", UnitShort = "F", UnitType = "Temperature" };
            Unit outputUnit = new Unit { UnitLong = "Kelvin", UnitShort = "K", UnitType = "Degrees" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 267.15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsFahrenheitToCelsius()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Fahrenheit", UnitShort = "F", UnitType = "Temperature" };
            Unit outputUnit = new Unit { UnitLong = "Celsius", UnitShort = "C", UnitType = "Temperature" };


            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = -6;
            Assert.AreEqual(expected, actual);
        }
    }
}
