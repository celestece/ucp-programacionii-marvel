using System;

public class Villano : Personaje
{

    #region Atributos

   


    #endregion
    
    #region Constructor
    public Villano() : base()
    {
       
    }

    public Villano(string nom, int anio, string univ, int stam) : base(nom, anio, univ, stam)
    {
       
    }
    #endregion

    #region setters y getters

    #endregion

    #region metodos

    public override void Atacar(Personaje p)
    {
        base.Atacar(p);
        Console.WriteLine("Ataque al Superheroe! >:)");
    }


    #endregion
}