using System;

namespace SuperHeroesTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Villano Vil = new Villano();
            Superheroe Super = new Superheroe();
            Personaje Ganador = new Personaje();
            Combate Comb = new Combate(Super,Vil,Ganador,5);
        }
    }
}
