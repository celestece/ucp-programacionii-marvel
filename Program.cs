using System;

//utilice el metodo virtual para hacer uso de los conceptos avanzados de poo ya que queria senalizar que un ataque iba a 
//ocurrir antes de que este ocurra. Por lo que queria extender los metodos en cada una de las clases derivadas(Superheroe, Villano)
//en vez de sobreescribirlos como seria necesario en una clase abstracta

namespace SuperHeroesTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Villano vil = new Villano();
            Superheroe sup = new Superheroe();
            Combate comb = new Combate(sup,vil, 5);

            vil.Atacar(sup);
            sup.Atacar(vil);
        }
    }
}
