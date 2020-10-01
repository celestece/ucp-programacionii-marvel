public class Superpoder{

    #region Atributos

    private bool Tipo;
    private int CantidadUsos;

    #endregion
    
    #region Constructor
    public Superpoder(){
        this.Tipo = false;
        this.CantidadUsos = 0;
    }

    public Superpoder(bool valor1, int valor2){
        this.Tipo = valor1;
        this.CantidadUsos = valor2;
    }
    #endregion

    #region setters y getters
    //set
    public void SetTipo(bool valor){
        this.Tipo = valor;
    }

    public void SetCantidadUsos(int valor){
        this.CantidadUsos = valor;
    }
    //get
    public bool GetTipo(){
        return this.Tipo;
    }

    public int GetCantidadUsos(){
        return this.CantidadUsos;
    }
    #endregion

    #region metodos

    public void Usar(Superheroe s){
        
    }

    #endregion
}