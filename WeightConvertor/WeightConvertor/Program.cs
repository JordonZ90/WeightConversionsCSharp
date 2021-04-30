using System;

namespace WeightConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            WeightConvertor();
        }
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Pounds to Stone");
            Console.WriteLine("2. Stone to Pounds");
            Console.WriteLine("3. Pounds to Kilograms");
            Console.WriteLine("4. Kilograms to Pounds");
            Console.WriteLine("5. Kilograms to Stone");
            Console.WriteLine("6. Stone to Kilograms");
            Console.WriteLine("7. Ounces to Grams");
            Console.WriteLine("8. Grams to Ounces");
            Console.WriteLine("");
        }
        public static void WeightConvertor()
        {
            string again = "y";
            while (again == "y".ToLower())
            {
                Console.WriteLine("Enter a menu option ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter weight in Pounds");
                    double pounds = Convert.ToDouble(Console.ReadLine());
                    double stone = WeightMethods.PoundsToStone(pounds);
                    stone = Math.Round(stone, 2);
                    Console.WriteLine($"Weight in {stone} Stone");
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter weight in Stone");
                    double stone = Convert.ToDouble(Console.ReadLine());
                    double pounds = WeightMethods.StoneToKilograms(stone);
                    pounds = Math.Round(pounds, 2);
                    Console.WriteLine($"Weight in {pounds} Pounds");
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter weight in Pounds");
                    double pounds = Convert.ToDouble(Console.ReadLine());
                    double kilograms = WeightMethods.PoundsToKilograms(pounds);
                    kilograms = Math.Round(kilograms, 2);
                    Console.WriteLine($"Weight in {kilograms} Kilograms");

                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter weight in Kilograms");
                    double kilograms = Convert.ToDouble(Console.ReadLine());
                    double pounds = WeightMethods.KiloGramsToPounds(kilograms);
                    pounds = Math.Round(pounds, 2);
                    Console.WriteLine($"Weight in {pounds} Pounds");
                }
                else if (option == 5)
                {
                    Console.WriteLine("Enter weight in Kilograms");
                    double kilograms = Convert.ToDouble(Console.ReadLine());
                    double stone = WeightMethods.KilogramsToStone(kilograms);
                    stone = Math.Round(stone, 2);
                    Console.WriteLine($"Weight in {stone} Stone");
                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter weight in Stone");
                    double stone = Convert.ToDouble(Console.ReadLine());
                    double kilograms = WeightMethods.StoneToKilograms(stone);
                    kilograms = Math.Round(kilograms, 2);
                    Console.WriteLine($"Weight in {kilograms} Kilograms");
                }
                else if (option == 7)
                {
                    Console.WriteLine("Enter weight in Ounces");
                    double ounces = Convert.ToDouble(Console.ReadLine());
                    double grams = WeightMethods.OuncesToGrams(ounces);
                    grams = Math.Round(grams, 2);
                    Console.WriteLine($"Weight in {grams} Grams");
                }
                else if (option == 8)
                {
                    Console.WriteLine("Enter weight in Grams");
                    double grams = Convert.ToDouble(Console.ReadLine());
                    double ounces = WeightMethods.GramsToOunces(grams);
                    ounces = Math.Round(ounces, 2);
                    Console.WriteLine($"Weight in {ounces} Ounces");
                }
                else
                {
                    Console.WriteLine("You must enter a valid menu number");
                }

                Console.WriteLine("Convert another measurement? (y|n)");
                again = Console.ReadLine();
                if (again == "y")
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
