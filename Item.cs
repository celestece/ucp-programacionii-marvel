public class Item{

    #region Atributos

    private string Tipo;
    

    #endregion
    
    #region Constructor
    public Item(){
        this.Tipo = "";
        
    }

    public Item(string valor){
        this.Tipo = valor;
        
    }
    #endregion

    #region setters y getters
    //set
    public void SetTipo(string valor){
        this.Tipo = valor;
    }

    //get
    public string GetTipo(){
        return this.Tipo;
    }

    #endregion

    #region metodos

    public string SortearTipoItem(){
        return this.Tipo;
    }

    #endregion
}