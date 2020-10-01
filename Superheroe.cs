public class Superheroe{

    #region Atributos

    private int CantidadVidas;
    private Superpoder Superpoder;
    private string Nombre;
    private int AnioCreacion;
    private string Universo;
    private int Stamina;

    #endregion
    
    #region Constructor
    public Superheroe(){
        this.CantidadVidas = 0;
        this.Superpoder = new Superpoder();
        this.Nombre = "";
        this.AnioCreacion = 0;
        this.Universo = "";
        this.Stamina = 0;
    }

    public Superheroe(int valor1, Superpoder valor2, string nom, int anio, string univ, int stam){
        this.CantidadVidas = valor1;
        this.Superpoder = valor2;
        this.Nombre = nom;
        this.AnioCreacion = anio;
        this.Universo = univ;
        this.Stamina = stam;
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
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
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

    public Item ObtenerItem(){
        return new Item();
    }
    public void Usar(Item item){
        
    }
    public void Usar(int ataque){
        
    }
    public void Usar(){
        
    }
    public void Atacar(Villano p){
        
    }

    #endregion
}