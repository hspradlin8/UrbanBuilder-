using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // City CatCity = new City()

            Building Edward = new Building("512 8th Avenue")
            {
                Width = 1000,
                Height = 2000,
                Depth = 500,
                Stories = 13,
            };

            Building Frankenstein = new Building("512 8th Avenue")
            {
                Width = 1500,
                Height = 666,
                Depth = 400,
                Stories = 13,
            };

            Building LilJerry = new Building("512 8th Avenue")
            {
                Width = 2500,
                Height = 2000,
                Depth = 300,
                Stories = 13,
            };
            // Have business people in your city purchase each of your buildings.

            Edward.Purchase("David");
            Frankenstein.Purchase("Lauren");
            LilJerry.Purchase("Seth");

            Console.WriteLine(Edward.Description);
            Console.WriteLine(Frankenstein.Description);
            Console.WriteLine(LilJerry.Description);
        }
    }
}