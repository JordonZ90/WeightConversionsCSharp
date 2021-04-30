using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightConvertor
{
    public class WeightMethods
    {
        public static double PoundsToStone(double pounds)
        {
            double stone = pounds / 14;
            return stone;
        }
        public static double StoneToPounds(double stone)
        {
            double pounds = stone * 14;
            return pounds;
        }
        public static double PoundsToKilograms(double pounds)
        {
            double kilograms = pounds * 0.45359237;
            return kilograms;
        }
        public static double KiloGramsToPounds(double kilograms)
        {
            double pounds = kilograms * 2.2046;
            return pounds;
        }
        public static double KilogramsToStone(double kilograms)
        {
            double stone = kilograms / 6.35029318;
            return stone;
        }
        public static double StoneToKilograms(double stone)
        {
            double kilograms = stone * 6.35029318;
            return kilograms;
        }
        public static double OuncesToGrams(double ounces)
        {
            double grams = ounces * 28.3495231;
            return grams;
        }
        public static double GramsToOunces(double grams)
        {
            double ounces = grams / 28.3495231;
            return ounces;
        }
    }
}
