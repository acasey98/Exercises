using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Thrall
    {
        public string Taunt { get; set; }
        public bool ThatsIncredible { get; set; }
        public Thrall(bool thatsincredible, string taunt)
        {
            ThatsIncredible = thatsincredible;
            Taunt = taunt;
        }
        public void Hex()
        {
            Console.WriteLine($"{Taunt} That's Incredible! {ThatsIncredible}");
        }
    }
}
