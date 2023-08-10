namespace Supermercado;

public static class Env
{
    private static string fileName="productos.json" ;
    private static List<Productos> productos=new List<Productos>();
    public static string FileName{get=> fileName; set=> fileName=value; }
    public static List<Productos> Productos{get=> productos; set=> productos=value; }
}