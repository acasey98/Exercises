using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your mmr?");
            var xd = new Dota(Console.ReadLine(), true);
            Console.WriteLine("What ability do you want to cast?");
            var cancer = new HOHOHAHA(Console.ReadLine(), 2);
            Console.WriteLine("How do you feel about stomping grapes?");
            var what = new Grape(Console.ReadLine(), false);
            Console.WriteLine("Taunty");
            var shaman = new Thrall(true, Console.ReadLine());

            shaman.Hex();
            what.Stomp();
            cancer.Cast();
            xd.Feed();
        }
    }
}
