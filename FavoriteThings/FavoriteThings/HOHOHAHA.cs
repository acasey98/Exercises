using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class HOHOHAHA
    {
        public string Shrapnel { get; set; }
        public int Damage { get; set; }
        public HOHOHAHA(string shrapnel, int dmg)
        {
            Shrapnel = shrapnel;
            Damage = dmg;
        }
        public void Cast()
        {
            Console.WriteLine($"Casted {Shrapnel} for {Damage} dmg");
        }
    }
}
