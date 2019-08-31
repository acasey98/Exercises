using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Dota
    {
        public string MMR { get; set; }
        public bool Tilted { get; set; }
        public Dota(string mmr, bool tilted)
        {
            Tilted = tilted;
            MMR = mmr;
        }
        public void Feed()
        {
            Console.WriteLine($"MMR: {MMR} Tilted: {Tilted}");
        }
    }
}
