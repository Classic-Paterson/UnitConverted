using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitConverter
{
    public class UnitConverter
    {
        public static void Main()
        {
            List<Unit> unitArray = new List<Unit>();

            unitArray.Add(new Unit { UnitLong = "Kelvin", UnitShort = "K", UnitType = "Temperature" });
            unitArray.Add(new Unit { UnitLong = "Celsius", UnitShort = "C", UnitType = "Temperature" });
            unitArray.Add(new Unit { UnitLong = "Fahrenheit", UnitShort = "F", UnitType = "Temperature" });
            unitArray.Add(new Unit { UnitLong = "Litre", UnitShort = "l", UnitType = "Measurement" });
            unitArray.Add(new Unit { UnitLong = "Millilitre", UnitShort = "ml", UnitType = "Measurement" });
            unitArray.Add(new Unit { UnitLong = "Gallon", UnitShort = "gal", UnitType = "Measurement" });

            //Input parameters: input value, input unit, output unit
            Console.WriteLine("Insert Value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Unit");
            Console.WriteLine($"Examples are: {exampleStringBuilder(unitArray)}");
            string inputUnitString = Console.ReadLine().ToLower();

            Unit inputUnit = unitArray.FirstOrDefault(x => x.UnitLong.ToLower() == inputUnitString || x.UnitShort.ToLower() == inputUnitString);

            Console.WriteLine("Output Unit: ");
            Console.WriteLine($"Examples are: {exampleStringBuilder(unitArray, inputUnit)}");
            string outputUnitString = Console.ReadLine().ToLower();

            Unit outputUnit = unitArray.FirstOrDefault(x => x.UnitLong.ToLower() == outputUnitString || x.UnitShort.ToLower() == outputUnitString);

            Console.WriteLine($"{value} {inputUnit.UnitLong} converted to {outputUnit.UnitLong} is: {convertThemUnits(value, inputUnit, outputUnit)} {outputUnit.UnitLong}'s");

            Console.ReadKey();
            Console.Clear();

            Main();
        }

        public static string exampleStringBuilder(List<Unit> unitArray, Unit inputUnit = null)
        {
            string exampleString = "";

            if (inputUnit != null)
            {
                var unitToRemove = unitArray.FirstOrDefault(x => x == inputUnit);

                unitArray.RemoveAll(x => x == unitToRemove);

                unitArray.RemoveAll(x => x.UnitType != unitToRemove.UnitType);
            }

            foreach (var unit in unitArray)
            {
                exampleString = exampleString + unit.UnitLong + $"({ unit.UnitShort}), ";
            }

            return exampleString;
        }

        public static double convertThemUnits(int value, Unit inputUnit, Unit outputUnit)
        {
            #region Temperatures
            if (inputUnit.UnitShort == "K" && outputUnit.UnitShort == "C")
            {
                //kelvin to Celsius
                return value - -273.1;
            }
            else if (inputUnit.UnitShort == "K" && outputUnit.UnitShort == "F")
            {
                //Kelvin to Fahrenheit
                return (value - 273.15) * 9 / 5 + 32;

            }
            else if (inputUnit.UnitShort == "C" && outputUnit.UnitShort == "K")
            {
                //Celsius to Kelvin
                return value + 273.1;
            }
            else if (inputUnit.UnitShort == "C" && outputUnit.UnitShort == "F")
            {
                //Celsius to Fahrenheit
                return (value * 9 / 5) + 32;
            }
            else if (inputUnit.UnitShort == "F" && outputUnit.UnitShort == "K")
            {
                //Fahrenheit to Kelvin
                return (value - 32) * 5 / 9 + 273.15;
            }
            else if (inputUnit.UnitShort == "F" && outputUnit.UnitShort == "C")
            {
                //Fahrenheit to Celsius
                return (value - 32) * 5 / 9;
            }
            #endregion

            #region Measurement
            if (inputUnit.UnitShort == "l" && outputUnit.UnitShort == "ml")
            {
                //Litre to Millilitre
                return value * 1000;
            }
            else if (inputUnit.UnitShort == "l" && outputUnit.UnitShort == "gal")
            {
                //Litre to Gallon
                return value / 3.785;

            }
            else if (inputUnit.UnitShort == "ml" && outputUnit.UnitShort == "l")
            {
                //Millilitre to Litre
                return value / 1000;
            }
            else if (inputUnit.UnitShort == "ml" && outputUnit.UnitShort == "gal")
            {
                //Millilitre to Gallon
                return value / 3785.412;

            }
            else if (inputUnit.UnitShort == "gal" && outputUnit.UnitShort == "l")
            {
                //Gallon to Litre
                return value * 3.785;
            }
            else if (inputUnit.UnitShort == "gal" && outputUnit.UnitShort == "ml")
            {
                //Gallon to Millilitre
                return value * 3785.412;
            }
            #endregion

            else
            {
                throw new ArgumentException("Parameters are not handled");
            }
        }
    }
}
