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
        static void FavJuice(out string j1, out string j2, out string j3)
        {
            j1 = "Mango";
            j2 = "MuskMelon";
            j3 = "Pineapple";
        }
        static void Main(string[] args)
        {

            string food1;
            string food2;
            string food3;

            string juice1;
            string juice2;
            string juice3;


            FavFood(out food1, out food2, out food3);
            FavJuice(out juice1, out juice2, out juice3);
            Console.WriteLine($"My Top 3 Fav Foods are \n1.{food1},\n2.{food2} and\n3.{food3}");
            Console.WriteLine($"My Top 3 Fav Juices are \n1.{juice1},\n2.{juice2} and\n3.{juice3}");


        }
    }
}
