namespace Supermercado.View;

public class Menuprincipal
{
    public Menuprincipal()
    {

    }

    public int Menu()
    {
            //Console.Clear();
            Console.WriteLine("1.Registrar Productos");
            Console.WriteLine("2.Registrar Categorias");
            Console.WriteLine("3.Listar productos");
            Console.WriteLine("4.Listar categorias");
            Console.WriteLine("5.Costo total del inventario");
            Console.WriteLine("6.Salir");

            return int.Parse(Console.ReadLine());
    }  
}