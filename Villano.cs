public class Villano{

    #region Atributos

    private string Nombre;
    private int AnioCreacion;
    private string Universo;
    private int Stamina;


    #endregion
    
    #region Constructor
    public Villano(){
        this.Nombre="";
        this.AnioCreacion=0;
        this.Universo="";
        this.Stamina=0;
    }

    public Villano(string nom, int anio, string univ, int stam){
        this.Nombre=nom;
        this.AnioCreacion=anio;
        this.Universo=univ;
        this.Stamina=stam;
    }
    #endregion

    #region setters y getters
    //set
    public void SetNombre(string nom){
        this.Nombre=nom;
    }

    public void SetAnioCreacion(int anio){
        this.AnioCreacion=anio;
    }
    public void SetUniverso(string univ){
        this.Universo=univ;
    }
    public void SetStamina(int stam){
        this.Stamina=stam;
    }
    //get
    public string GetNombre(){
        return this.Nombre;
    }

    public int GetAnioCreacion(){
        return this.AnioCreacion;
    }
    public string GetUniverso(){
        return this.Universo;
    }
    public int GetStamina(){
        return this.Stamina;
    }

    
    #endregion

    #region metodos

    public void Atacar(Superheroe p){
        
    }
    #endregion
}