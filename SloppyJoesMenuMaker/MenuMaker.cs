using System;

namespace SloppyJoesMenuMaker
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Chicken", "Ham", "Pastrami", "Meatball", "Sausage" };
        string[] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard",
                    "Mayo", "Relish", "French Dressing", "Sriracha", "Buffalo Sauce", "Ketchup", "Vineager and Oil" };
        string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "Italian",
                    "French", "Sourdough", "Pita", "Naan", "Hoagie"};

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread + " Bread.";
        }
    }
}
