using System;

public class Superheroe : Personaje
{

    #region Atributos

    private int CantidadVidas;
    private Superpoder Superpoder;

    #endregion
    
    #region Constructor
    public Superheroe() : base()
    {
        this.CantidadVidas = 0;
        this.Superpoder = new Superpoder();
        
    }

    public Superheroe(int valor1, Superpoder valor2, string nom, int anio, string univ, int stam) : base( nom, anio, univ, stam)
    {
        this.CantidadVidas = valor1;
        this.Superpoder = valor2;
    }
    #endregion

    #region setters y getters
    //set
    public void SetCantidadVidas(int valor){
        this.CantidadVidas = valor;
    }

    public void SetSuperpoder(Superpoder valor){
        this.Superpoder = valor;
    }
    
    //get
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
   
    #endregion

    #region metodos

    public Item ObtenerItem(){
        return new Item();
    }
    public void Usar(Item item){
        
    }
    public void Usar(int ataque){
        
    }
    public void Usar(){
        
    }

    public override void Atacar(Personaje p)
    {
        base.Atacar(p);
        Console.WriteLine("Ataque al villano!");

    }

    #endregion
}