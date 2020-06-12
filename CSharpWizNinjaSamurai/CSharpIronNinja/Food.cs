using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food : IConsumable
    {
        public string Name{get;set;}
        public int Calories{get;set;}
        public bool IsSpicy{get;set;}
        public bool IsSweet{get;set;}
        public string GetInfo()
        {
            return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name=name;
            Calories=calories;
            IsSpicy = isSpicy;
            IsSweet=isSweet;
        }
    }
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu= new List<IConsumable>()
            {
                new Food("Pizza", 285, false, false),
                new Food("Cupcake", 131, false, true),
                new Food("Burger", 800, false, false),
                new Food("Spicy Wings", 500, true, false),
                new Food("Ice Cream", 150, false, true),
                new Drink("Root Beer", 180, false, true),
                new Drink("Grape Sode", 180, false, true),
                new Drink("Lemonade", 180, false, true)

            };
        }
        public IConsumable Serve()
        {
            Random randFood = new Random();
            int randInt=randFood.Next(Menu.Count);
            return Menu[randInt];
        }
    }
}