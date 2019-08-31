using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Grape
    {
        public bool Stomped { get; set; }
        public string Feelings { get; set; }
        public Grape(string feelings, bool stomped)
        {
            Feelings = feelings;
            Stomped = stomped;
        }
        public void Stomp()
        {
            Console.WriteLine($"Stomped: {Stomped} {Feelings}");
        }
    }
}
