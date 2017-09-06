using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Piano
    {
        public void Toca(List<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
