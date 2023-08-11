using Supermercado.Entities;
namespace Supermercado;
public static class Env
{
    private static string fileName="Supermercado.json" ;
    private static SuperMercado supermercado=new SuperMercado();
    public static string FileName {get=> fileName; set=> fileName=value; }
    // private static List<Productos> productos=new List<Productos>();
    // public static string FileName{get=> fileName; set=> fileName=value; }
    // public static List<Productos> Productos{get=> productos; set=> productos=value; }
    public static SuperMercado Supermercado{get=> supermercado; set=> supermercado=value; }

    public static void LoadDataProductos(string nombreArchivo){
        using (StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            Env.Supermercado= System.Text.Json.JsonSerializer.Deserialize<SuperMercado>(json, new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true})?? new SuperMercado();

        }
    }
    public static bool ValidarFile(string fileName){
        if(!File.Exists(fileName)){
            return false;
        }
        return true;
    }
    public static void ImprimirData<T>(string titulo, IEnumerable<T> lista){
        System.Console.WriteLine("{0,-30}", titulo);
        foreach(var elemento in lista)
        {
            Type tipoclase= elemento.GetType();
            var propiedades= tipoclase.GetProperties();
            foreach(var propiedad in propiedades){
                System.Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(elemento)}");
            }

        }
        Console.ReadKey();
    }
}