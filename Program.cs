using System;

namespace Practice
{
    class Program
    {
        static void FavFood(out string f1, out string f2, out string f3)
        {
            f1 = "Biryani";
            f2 = "Pizza";
            f3 = "Burger";
        }
        static void Main(string[] args)
        {
            string food1;
            string food2;
            string food3;
            FavFood(out food1, out food2, out food3);
            Console.WriteLine($"My Top 3 Fav Foods are \n1.{food1},\n2.{food2} and\n3.{food3}");

        }
    }
}
