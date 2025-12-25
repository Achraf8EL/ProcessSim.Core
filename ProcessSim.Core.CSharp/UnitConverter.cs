using System;

namespace ProcessSim.Core.CSharp
{
    public static class UnitConverter
    {
        public static double MgPerMlToGPerL(double value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "La valeur ne peut pas être négative.");
            return value;
        }

        public static double GPerLToMgPerMl(double value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "La valeur ne peut pas être négative.");
            return value;
        }

        public static double MlToL(double value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "La valeur ne peut pas être négative.");
            return value / 1000.0;
        }

        public static double LToMl(double value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "La valeur ne peut pas être négative.");
            return value * 1000.0;
        }

        public static double CelsiusToKelvin(double value) => value + 273.15;

        public static double KelvinToCelsius(double value) => value - 273.15;
    }
}
