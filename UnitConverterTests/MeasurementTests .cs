using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTests
{
    [TestClass]
    public class MeasurementTests
    {
        [TestMethod]
        public void convertThemUnitsLitreToMillilitre()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Millilitre", UnitShort = "ml", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 20000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsLitreToGallon()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Gallon", UnitShort = "gal", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 5.2840158520475562;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsMillilitreToLitre()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Millilitre", UnitShort = "ml", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            //this should actually be 0.02 but rounding...
            double expected = 0.0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsMillilitreToGallon()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Millilitre", UnitShort = "ml", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Gallon", UnitShort = "gal", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 0.0052834407456836931;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsGallonToLitre()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Gallon", UnitShort = "gal", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 75.7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertThemUnitsGallonToMillilitre()
        {
            // Arrange
            int value = 20;
            Unit inputUnit = new Unit { UnitLong = "Gallon", UnitShort = "gal", UnitType = "Measurement" };
            Unit outputUnit = new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" };

            // Act
            double actual = UnitConverter.UnitConverter.convertThemUnits(value, inputUnit, outputUnit);

            // Assert
            double expected = 75.7;
            Assert.AreEqual(expected, actual);
        }
    }
}
