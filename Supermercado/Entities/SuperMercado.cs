namespace Supermercado.Entities;

public class SuperMercado{
    private List<Producto> productos=new List<Producto>();
    private List<Categoria> categorias=new List<Categoria>();
    public List<Categoria> Categorias{
        get{ return categorias; }
        set{categorias=value;}

    }
    public List<Producto> Productos{
        get{ return productos; }
        set{ productos=value;}
    }
    public SuperMercado(){}
}
