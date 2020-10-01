using System.Collections.Generic;
public class Juego{

    #region Atributos

    private bool Resultado;
    private int Nivel;
    private List<Combate> Combates;


    #endregion
    
    #region Constructor
    public Juego(){
        this.Resultado = false;
        this.Nivel = 0;
        this.Combates = new List<Combate>();
    }

    public Juego(bool resu, int niv, List<Combate> comb){
        this.Resultado = resu;
        this.Nivel = niv;
        this.Combates = comb;
    }
    #endregion

    #region setters y getters
    //set
    public void SetResultado(bool resu){
        this.Resultado = resu;
    }

    public void SetNivel(int niv){
        this.Nivel = niv;
    }
    public void SetCombates(List<Combate> comb){
        this.Combates = comb;
    }
    //get
    public bool GetResultado(){
        return this.Resultado;
    }

    public int GetNivel(){
        return this.Nivel;
    }
    public List<Combate> GetCombates(){
        return this.Combates;
    }
    #endregion

    #region metodos

    public void Comenzar(){
        
    }
    public void Terminar(){

    }

    #endregion
}